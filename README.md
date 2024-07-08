# TaskTracker API

TaskTracker is a backend API for simple todo list application built using ASP.NET Core.

### Dependencies
- ASP.NET Core
- Entity Framework Core
- ASP.NET Core Identity
- JWT Bearer Authentication
- Swagger for API documentation


### Installation

1. **Clone the repository:**

    ```bash
    git clone https://github.com/yourusername/TaskTracker.git
    cd TaskTracker
    ```

2. **Set up the database connection in `appsettings.json`:**

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Your-SQLServer-Connection-String"
      },
      "JWT": {
        "Issuer": "YourIssuer",
        "Audience": "YourAudience",
        "SigningKey": "YourSigningKey"
      }
    }
    ```

3. **Apply migrations and update the database:**

    ```bash
    dotnet ef database update
    ```

### Build & run the project
```bash
dotnet build
dotnet run
```

