# Neva Tirzah Prison Management System

This project is a Prison Management System for the women's prison "Neva Tirzah." The system is built using .NET and provides various functionalities to manage prisoners, staff, and daily operations within the prison.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)

## Features

- **Prisoner Management**: Add, update, and delete prisoner information.
- **Staff Management**: Manage staff details and roles.
- **Daily Operations**: Record and manage daily activities within the prison.
- **Security**: Implement user authentication and authorization.
- **Reporting**: Generate reports on various aspects of prison management.

## Technologies Used

- **Framework**: .NET 6
- **Database**: SQL Server
- **Frontend**: ASP.NET Core MVC
- **Authentication**: ASP.NET Identity
- **Logging**: Serilog
- **Testing**: xUnit

## Getting Started

To get a local copy of the project up and running, follow these steps.

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. **Clone the repository:**

    ```bash
    git clone https://github.com/SaraToprowitch/NevaTirzhaPrisoner.git
    cd NevaTirzhaPrisoner
    ```

2. **Set up the database:**

    Ensure SQL Server is running and create a database for the project. Update the connection string in `appsettings.json` with your database details.

3. **Apply migrations:**

    ```bash
    dotnet ef database update
    ```

4. **Run the application:**

    ```bash
    dotnet run
    ```

5. **Access the application:**

    Open your web browser and navigate to `http://localhost:5000`.

## Usage

After setting up the project, you can start using the system to manage prisoners, staff, and daily operations. The system includes various modules for different functionalities:

- **Dashboard**: Overview of prison statistics.
- **Prisoners**: Add, update, and delete prisoner records.
- **Staff**: Manage staff members and assign roles.
- **Activities**: Log daily activities and incidents.
- **Reports**: Generate and download various management reports.

## Contributing

We welcome contributions to improve the Neva Tirzah Prison Management System! To contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a pull request.

---

Feel free to reach out if you have any questions or need further assistance. Thank you for using the Neva Tirzah Prison Management System!
