# What Am I Craving For? (Backend API)

This is the backend API for **What Am I Craving For?** A food-picker application that knows what you want, even when you absolutely do not.
**Frontend Repo:** [Repo Link](https://github.com/briankabbo/what-am-i-craving-for-frontend)

>  **Status: Work In Progress**

---

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | .NET 9 (ASP.NET Core Web API) |
| Language | C# |
| Database | Microsoft SQL Server (MSSQL) |
| ORM | Entity Framework Core |
| API Style | RESTful |

---

## Project Structure

```
what-am-i-craving-for/
├── AppDbContext.cs           # EF Core database context — the brain connecting code to database
├── Food.cs                   # Food model — represents a food item
├── Favourite.cs              # Favourite model — represents a saved favourite
├── FoodsController.cs        # Handles all food-related API endpoints
├── FavouritesController.cs   # Handles all favourites-related API endpoints
├── Program.cs                # App entry point and service configuration
├── Migrations/               # EF Core database migrations
├── appsettings.json          # App configuration (connection strings, etc.)
└── appsettings.Development.json  # Dev-specific overrides
```

---

## Getting Started

### Prerequisites

Make sure you have the following installed before you even think about running this:

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/) with the C# extension

### Installation and Setup

**Step 1.** Clone the repository.

```bash
git clone https://github.com/briankabbo/what-am-i-craving-for.git
cd what-am-i-craving-for
```

**Step 2.** Open `appsettings.json` and update the connection string to point to your local SQL Server instance.

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=FoodPickerDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

Replace `YOUR_SERVER_NAME` with your actual SQL Server name (often `localhost` or `.\SQLEXPRESS`).

**Step 3.** Apply the database migrations to create your database schema.

```bash
dotnet ef database update
```

This reads the `Migrations/` folder and sets up all the tables for you automatically. Entity Framework is doing the heavy lifting here so you do not have to write SQL by hand.

**Step 4.** Run the API.

```bash
dotnet run
```

The API will start up and by default be available at `https://localhost:5001` or `http://localhost:5000`.

---

## API Endpoints

### Foods

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/foods` | Get all available foods |
| GET | `/api/foods/{id}` | Get a specific food by ID |
| POST | `/api/foods` | Add a new food |
| PUT | `/api/foods/{id}` | Update an existing food |
| DELETE | `/api/foods/{id}` | Delete a food |

### Favourites

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/favourites` | Get all saved favourites |
| GET | `/api/favourites/{id}` | Get a specific favourite |
| POST | `/api/favourites` | Save a food as a favourite |
| DELETE | `/api/favourites/{id}` | Remove a food from favourites |

---

## 🔗 Related Repository

This API is one half of the full project. The frontend is a React + Vite application that consumes this API and presents the user with a friendly interface to discover and save their cravings.

👉 [Frontend Repository](https://github.com/briankabbo/what-am-i-craving-for-frontend)

---

## 🤝 Contributing

This project is a work in progress and contributions are welcome! If you spot a bug, have an idea, or just want to add more food options (priorities, right?), feel free to open an issue or submit a pull request.

---

*Built with hunger and a little too much ambition. 🍜*
> Stay tuned as things are built, broken, and fixed in that exact order.
