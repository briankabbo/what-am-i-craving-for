using Microsoft.EntityFrameworkCore;
using FoodPickerAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// ── Database ──────────────────────────────────────────────────────
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// ── CORS — allow React frontend ───────────────────────────────────
var allowedOrigins = builder.Configuration["AllowedOrigins"]?
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    ?? new[] { "http://localhost:5173", "http://localhost:3000" };

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
        policy.WithOrigins(allowedOrigins)
              .AllowAnyHeader()
              .AllowAnyMethod());
});

// ── Services ──────────────────────────────────────────────────────
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "FoodPicker API", Version = "v1" });
});

// ── Problem Details (structured error responses) ──────────────────
builder.Services.AddProblemDetails();

var app = builder.Build();

// ── Global exception handler ──────────────────────────────────────
app.UseExceptionHandler(err => err.Run(async context =>
{
    context.Response.StatusCode = 500;
    context.Response.ContentType = "application/json";
    await context.Response.WriteAsJsonAsync(new
    {
        message = "An unexpected error occurred. Please try again later."
    });
}));

// ── Dev tools ─────────────────────────────────────────────────────
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FoodPicker API v1"));
}

// ── Middleware pipeline ───────────────────────────────────────────
app.UseHttpsRedirection();
app.UseCors("AllowFrontend");
app.UseAuthorization();
app.MapControllers();

app.Run();
