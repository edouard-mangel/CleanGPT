# CleanGPT
Clean architecture webAPI example with ChatGPT4. I try to go as far as possible only generating prompts

markdown
Copy code
# Clean Architecture Example

This is an example of a clean architecture project using .NET 6, xUnit, FluentMigrator, and PostgreSQL. The project demonstrates how to organize code in a clean architecture pattern, create migrations, and perform testing using TDD.

## Prerequisites

- .NET 6 SDK
- Docker
- Docker Compose

## Installation

1. Clone the repository:

git clone https://github.com/yourusername/CleanArchitectureExample.git
cd CleanArchitectureExample

markdown
Copy code

2. Build the solution:

dotnet build

markdown
Copy code

3. Run the tests:

dotnet test

markdown
Copy code

## Running the application

1. Set the following environment variables:

- `POSTGRESQL_CONNECTION_STRING`: Connection string for the PostgreSQL database.
- `POSTGRES_USER`: PostgreSQL username.
- `POSTGRES_PASSWORD`: PostgreSQL password.

For example, on Linux or macOS, run:

export POSTGRESQL_CONNECTION_STRING='Host=db;Database=CleanArchitectureExample;Username=myuser;Password=mypassword'
export POSTGRES_USER=myuser
export POSTGRES_PASSWORD=mypassword

graphql
Copy code

On Windows, in PowerShell, run:

$env:POSTGRESQL_CONNECTION_STRING='Host=db;Database=CleanArchitectureExample;Username=myuser;Password=mypassword'
$env:POSTGRES_USER='myuser'
$env:POSTGRES_PASSWORD='mypassword'

sql
Copy code

2. Start the web application and PostgreSQL database using Docker Compose:

docker-compose up

bash
Copy code

3. Access the web application at http://localhost:5000 or https://localhost:5001.

## License

This project is licensed under the GNU/GPL license. See the LICENSE file for details.
