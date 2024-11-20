# .NET to PostgreSQL CRUD Application

This is a .NET Core application demonstrating CRUD (Create, Read, Update, Delete) operations by connecting a .NET Core application to a PostgreSQL database. The project showcases how to interact with PostgreSQL using Entity Framework Core.

---

## Features

- **Database**: PostgreSQL
- **CRUD Operations**:
  - Create: Insert data into the database.
  - Read: Fetch and display data from the database.
  - Update: Modify existing records in the database.
  - Delete: Remove records from the database.
- **ASP.NET Core**: Back-end logic written in .NET Core.
- **Entity Framework Core**: ORM for database interaction.

---

## Prerequisites

Before running this application, ensure the following tools are installed:

1. **PostgreSQL**: Set up a PostgreSQL database.
2. **.NET SDK**: Install the latest version of the .NET SDK.
3. **Visual Studio/Visual Studio Code**: For development and debugging.

---

## Configuration

1. **Update `appsettings.json`**:  
   Add your PostgreSQL connection string:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Port=5432;Database=YourDatabaseName;Username=YourUsername;Password=YourPassword"
     }
   }
