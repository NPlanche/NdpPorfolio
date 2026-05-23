# NdpPortfolio

NdpPortfolio is a personal portfolio application built with **ASP.NET Core MVC** using a layered architecture that separates domain models, business logic, infrastructure, and presentation concerns.

This project was created to demonstrate practical skills in **C#**, **ASP.NET Core**, **dependency injection**, and **clean project structure**.

## Overview

The application is designed as a portfolio website that can present projects, work experience, and contact information through a maintainable multi-project solution.

The solution is organized to reflect common enterprise-style architecture patterns:

- **Core** for domain entities and contracts
- **Application** for business logic and services
- **Infrastructure** for repository implementations
- **UI** for the ASP.NET Core MVC web application

## Solution Structure

```text
NdpPortfolio.sln

NdpPortfolio.Core
├── Entities
├── Enums
└── Interfaces
    ├── Repositories
    └── Services

NdpPortfolio.Application
└── Implementations
    └── Services

NdpPortfolio.Infrastructure
└── Implementations
    └── Repositories

NdpPortfolio.UI
├── Controllers
├── Models
├── Views
└── Program.cs
```

## Key Skills Demonstrated

- ASP.NET Core MVC application development
- Layered / clean architecture organization
- Dependency injection configuration
- Separation of concerns
- Repository pattern
- Service layer pattern
- Strongly typed Razor views
- Multi-project solution design in C#

## Current Features

- Displays portfolio project data on the home page
- Uses service and repository abstractions
- Demonstrates dependency injection setup in `Program.cs`
- Separates business logic from presentation logic
- Uses in-memory repository implementations for development

## Technologies Used

- **C#**
- **ASP.NET Core MVC**
- **.NET**
- **Razor Views**
- **Dependency Injection**
- **Visual Studio**

## How to Run

### Prerequisites
- .NET SDK installed
- Visual Studio 2022 or later recommended

### Steps
1. Clone the repository
2. Open the solution in Visual Studio
3. Set **NdpPortfolio.UI** as the startup project
4. Build the solution
5. Run the application

## Architecture Notes

This project follows a clear dependency direction:

- `UI` depends on `Application`, `Infrastructure`, and `Core`
- `Application` depends on `Core`
- `Infrastructure` depends on `Core`
- `Core` depends on no other project

This structure keeps domain contracts centralized and makes the application easier to maintain, extend, and test.

## Future Enhancements

- Add database persistence with Entity Framework Core
- Expand the home page into a full portfolio experience
- Add work experience and contact sections
- Introduce view models for richer page composition
- Add form validation and contact submission workflow
- Add unit and integration tests
- Improve styling and responsive design

## Purpose

This project was built to strengthen and demonstrate backend and full-stack development fundamentals in a professional ASP.NET Core application structure.

## Author

Created by **NPlanche**