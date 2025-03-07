# FinanceApp

# FinanceApp

FinanceApp is a web application designed to help users manage their expenses efficiently. The application allows users to create, update, delete, and search for expenses, as well as filter them by category and visualize data through charts.

## Features

- Add new expenses with description, amount, category, and date.
- View a list of all recorded expenses.
- Edit and update existing expenses.
- Delete expenses as needed.
- Filter expenses by category.
- Search for expenses by description.
- View expense data in a chart format.

## Technologies Used

- **Backend**: ASP.NET Core MVC
- **Frontend**: Razor Views, HTML, CSS, JavaScript, Chart.js
- **Database**: Entity Framework Core (SQL Server or other supported databases)
- **Services**: Dependency Injection for Expense Management

## Installation and Setup

1. **Clone the Repository**
   ```sh
   git clone https://github.com/yourusername/FinanceApp.git
   cd FinanceApp
   ```

2. **Set Up Database**
   - Update the connection string in `appsettings.json`.
   - Run the migrations and update the database:
     ```sh
     dotnet ef database update
     ```

3. **Run the Application**
   ```sh
   dotnet run
   ```

4. **Access the App**
   Open your browser and navigate to `http://localhost:5000` or the port specified.

## Project Structure

```
FinanceApp/
│── Controllers/
│   ├── ExpensesController.cs
│── Models/
│   ├── Expense.cs
│── Data/
│   ├── ApplicationDbContext.cs
│   ├── Service/
│       ├── IExpensesService.cs
│       ├── ExpensesService.cs
│── Views/
│   ├── Expenses/
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       ├── Delete.cshtml
│── wwwroot/
│── appsettings.json
│── Program.cs
│── Startup.cs
│── README.md
```

## API Endpoints

| HTTP Method | Route                     | Description |
|------------|--------------------------|-------------|
| GET        | `/Expenses`               | List all expenses |
| GET        | `/Expenses/Create`        | Show create form |
| POST       | `/Expenses/Create`        | Create a new expense |
| GET        | `/Expenses/Edit/{id}`     | Show edit form |
| POST       | `/Expenses/Edit/{id}`     | Update an expense |
| GET        | `/Expenses/Delete/{id}`   | Show delete confirmation |
| POST       | `/Expenses/Delete/{id}`   | Delete an expense |
| GET        | `/Expenses/ByCategory`    | Filter expenses by category |
| GET        | `/Expenses/Search`        | Search expenses by description |
| GET        | `/Expenses/GetChart`      | Retrieve expense chart data |

## Contributing

1. Fork the repository.
2. Create a new branch (`feature-branch`).
3. Commit your changes (`git commit -m "Added a new feature"`).
4. Push the branch (`git push origin feature-branch`).
5. Create a Pull Request.

## License

This project is licensed under the MIT License. Feel free to use and modify it as needed.

## Contact

For any inquiries, please contact [your email or GitHub profile].

