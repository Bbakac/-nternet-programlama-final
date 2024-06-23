# IrisReadingApp

IrisReadingApp is a web application built using ASP.NET Core MVC. This application reads the Iris flower dataset (iris.json) and presents it to the user. The project is developed using EF Core 6.0 and ASP.NET Core MVC 6.0.

## Installation Instructions

### Creating the Project

1. Create a new ASP.NET Core MVC project using the following command:
    ```sh
    dotnet new mvc -n IrisReadingApp
    cd IrisReadingApp
    code .
    ```

### Installing Required Packages

2. Install the `Microsoft.AspNetCore.Mvc.NewtonsoftJson` package to read and process JSON files:
    ```sh
    dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 6.0.0
    ```

### Building and Running the Project

3. Restore the project dependencies by running:
    ```sh
    dotnet restore
    ```

4. Build and run the project:
    ```sh
    dotnet build
    dotnet run
    ```

5. Once the application is running, navigate to [http://localhost:5011/Iris](http://localhost:5011/Iris) in your browser.

## Project Structure

- **Controllers**
    - `HomeController.cs`
    - `IrisController.cs`
    - `OgrencilerController.cs`

- **Views**
    - `Yeni.cshtml`
    - `Detay.cshtml`
    - `Privacy.cshtml`
    - `Index.cshtml`
    - `Sil.cshtml`
    - `Guncelle.cshtml`

- **Models**
    - `Iris.cs`

- **Configurations**
    - `Program.cs`
    - `IrisReadingApp.csproj`
    - `IrisReadingApp.sln`

- **Static Assets**
    - `_Layout.cshtml`
    - `_Layout.cshtml.css`

### Details

- **iris.json**: Contains the Iris flower dataset. This dataset is read in JSON format and presented to users within the project.
- **Controllers**: The MVC controllers manage the application's logic and user interactions.
- **Views**: These are the pages and interfaces presented to the user.
- **Models**: Contain the data models.
- **Configurations**: Configuration files for the project.

## Project Requirements

- .NET 6.0 SDK
- Visual Studio Code (or any other IDE)

## How to Contribute

Follow these steps to contribute to the project:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Create a Pull Request.
