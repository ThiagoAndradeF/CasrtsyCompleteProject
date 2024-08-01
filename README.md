# Basic ERP for Small Businesses

This is a basic ERP system designed to meet the needs of small businesses. The system is developed using C# with Entity Framework for server logic and PostgreSQL for data persistence. On the frontend, we use Angular to create a rich and responsive user interface.

## Features (So far, only transaction and item registration have been implemented)

- **Inventory Control:** Manage your inventory, monitor stock levels, and receive alerts when it's time to restock.

## Technologies Used

- **Backend:** C# with ASP.NET Core and Entity Framework.
- **Frontend:** Angular with PrimeNG for UI components.
- **Database:** PostgreSQL.
- **API:** RESTful API design.

## Requirements

- .NET 5.0 or higher.
- Node.js 12.0 or higher.
- PostgreSQL 12 or higher.

## Setup

1. Clone the repository to your local machine.
2. Configure the PostgreSQL connection string in the `appsettings.json` file in the backend project.
3. Run the Entity Framework migrations to set up the database.
4. Install the Angular project dependencies by running `npm install` in the frontend folder.
5. Start the backend server and the Angular development server.

## Running the Project

To run the backend, follow these steps in your terminal:

```bash
# Install Entity Framework
# Install PostgreSQL
# Navigate to the Backend directory
cd Backend
dotnet restore
dotnet build
dotnet run

# After starting the backend, navigate to the Frontend directory
cd ../Frontend
npm start
