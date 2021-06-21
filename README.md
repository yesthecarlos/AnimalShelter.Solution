# _Animal Shelter_

#### _.NET 5 Animal Shelter API using EF Core 5, MySQL, and Swagger_

#### By _**Carlos Mendez**_

## Technologies Used

* C#
* .NET 5
* EF Core 5
* MySQL
* Swagger / Swashbuckle 5.6.3


## Description

_This project uses C#, .NET 5, EF Core 5, and MySQL to create an animal shelter API that allows the user to connect to and maintain a database for an animal shelter. The API endpoints allow for viewing, adding, editing, and removing animals from the database. It uses the Swashbuckle implementation of Swagger tooling to generate documentation based on the OpenAPI specification._


## Setup and Use

### Prerequisites
* [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)
* A web browser to run and interact with the web app.

### Installation
1. Clone the repository: `$ git clone https://github.com/yesthecarlos/AnimalShelter.Solution`
2. Navigate to the `AnimalShelter/` directory on your computer
3. Open with your preferred text editor to view the code base
4. Create a file named appsettings.json and save it in the project's root directory. It should contain the following code:
```c#
{
  "ConnectionStrings": 
  {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=[user];pwd=[password];"
  }
}
```
5. To run the API:
    * Navigate to `AnimalShelter/` in your command line
    * Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
    * Run the commmand `dotnet build` to build the project and its dependencies into a set of binaries
    * Run the command `dotnet ef database update` to build the database using the Migrations folder
    * Run the command `dotnet run` to run the project
    * Finally, open the project in your web browser, using the specified address (default is localhost:5000)

6. To access Swagger API Documentation:
    * While the project is running, navigate to the following address in your web browser: http://localhost:5000/swagger

### Endpoints
Base URL: `http://localhost:5000`

#### HTTP Request Structure
```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{id}
PUT /api/Animals/{id}
DELETE /api/Animals/{id}
```

#### Example Query
```
http://localhost:5000/api/Animals/6
```

#### Sample JSON Response
```
{
  "animalId": 6,
  "name": "Cornelius",
  "species": "Cat",
  "age": 3,
  "gender": "Male"
}
```

## Known Bugs

_No known bugs at this time._


## License

_Copyright 2021 Carlos Mendez_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

_

## Contact Information

_carlosmendez86@gmail.com_