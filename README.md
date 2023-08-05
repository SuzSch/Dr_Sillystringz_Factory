![Picture of four people in yellow jumpsuits working in a factory next to a large blue machine that has red robotic arms. There are also some plants with green foliage behind the machine.](https://img.freepik.com/premium-vector/assembly-line-with-robotic-arms-male-female-factory-worker-engineer-characters-automated-production-process-high-tech-machinery-industrial-revolution-concept-cartoon-people-vector-illustration_87771-15359.jpg)
# Dr. Sillystringz's Factory

#### An MVC web application to help Dr. Sillystringz manage their engineers, and the machines they are licensed to fix.
#### By Suzanne Schuber

## Technologies Used

* ASP.NET Core MVC
* Entity Framework Core
* C# 
* MySQL Database
* HTML
* CSS
* Git
* Razor Views

## In this application you are able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. An engineer can be licensed to repair many machines and a machine can have many engineers licensed to repair it. As the factory manager you can: 
* See a list of all engineers and all machines on the splash page.
* Select a engineer, see their details, and see a list of all machines that engineer is licensed to repair.
* Select a machine, see its details, and see a list of all engineers licensed to repair it.
* Add new engineers to our system when they are hired and add new machines to the system when they are installed.
* Add or remove machines that a specific engineer is licensed to repair and add or remove engineers from a specific machine.
* Delete a machine when it has been decommisioned.

## Setup/Installation Requirements

1. Clone this repo.
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's root directory called "Sillystrings.Solutions"
3. Add the following dependencies.
   * dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
   * dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
4. Add a .gitignore file to root directory.
5. add obj, bin, and appsettings.json to .gitignore file.
6. Within the production directory "Factory", create a new file called appsettings.json.
7. Within appsettings.json, put in the following code, replacing the database, uid and pwd values with your own database name, username and password for MySQL.
``````
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
``````
8. Run the following command in your terminal to install a tool called dotnet-ef globally to create migrations and update our database:
``````
$ dotnet tool install --global dotnet-ef --version 6.0.0
``````
9. Within the production directory "Factory", run the following command:
``````
$ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
``````
10. To create a new migration and update your database run the following command (within the "Factory" directory):
``````
$ dotnet ef migrations add Initial
``````
When we run the above command, a new migration will be created with the name Initial in a new folder called Migrations. If this is the first migration in a project, EF Core will automatically generate a Migrations folder in the root directory. Note that we can name our migration anything we want, but it's common for the first migration to contain the word Initial or something like it.

11. When naming subsequent migrations, start with a verb to describe the change that the migration will make to the database.

12. Once we have verified that the migration looks correct and made any necessary changes, we'll run the following command to update our database:
``````
$ dotnet ef database update
``````

13. Within the production directory "Factory", run dotnet watch run in the command line to start the project in development mode with a watcher.

## Known Bugs
Each time the project is opened, it generates a "Factory.sln file. This needs to be deleted, otherwise when you try to run the program you get an error that says "This folder contains more than one project or solution file." Not sure how to fix it but I'm guessing it has something to do with using dotnet new mvc.

## License
MIT License

Copyright (c) 2023 Suzanne Schuber

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.