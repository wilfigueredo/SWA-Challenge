# SWA Challenge — Star Wars API Full-Stack Challenge

A full-stack application built around the **Star Wars API (SWAPI)** to retrieve, organize and filter information about Star Wars characters, species and home worlds.

## About the project

This project was developed as a technical challenge and integrates an external API with a layered ASP.NET Core backend and an Angular frontend.

The backend retrieves character information from SWAPI, enriches it with home-world and species data and exposes the resulting information through its own API. The application also supports pagination and filtering characters by species.

> **Historical project:** this repository represents an earlier stage of my software engineering journey and is preserved as part of my development portfolio.

## Main features

- Consume the external SWAPI service
- Retrieve Star Wars characters with pagination
- Resolve each character's home world
- Resolve character species
- Filter characters by species
- REST API protected by authorization policies
- User authentication/identity infrastructure
- Redis distributed caching for character data
- Angular web interface

## Architecture

The solution is separated into distinct responsibilities:

```text
src/
├── SWA.WF.Domain          # Domain models, interfaces and services
├── SWA.WF.Infra.Data      # External API integration, DTOs and repositories
├── SWA.WF.Services.Api    # ASP.NET Core REST API, authentication and configuration
└── SWA.WF.UI              # Angular web application
```

The infrastructure layer contains repositories responsible for communicating with SWAPI, while the domain layer abstracts those operations behind services and interfaces. The API layer exposes the application functionality to the frontend.

## Tech stack

- C#
- ASP.NET Core 2.2
- Angular
- Entity Framework Core
- ASP.NET Core Identity
- Redis distributed cache
- REST APIs
- HttpClient
- Newtonsoft.Json

## External API integration

Character data is retrieved from the historical SWAPI endpoint. The application then performs additional requests to obtain the corresponding planet and species information before mapping the result to its domain model.

The original SWAPI endpoint referenced by the implementation may no longer be available at the same address, so running the application today may require adapting the external API configuration.

## Running the project

The original project requires:

- Node.js
- Redis
- ASP.NET Core 2.2.301-compatible SDK/runtime

### Backend

1. Clone the repository.
2. Open `SWA-challenge.sln`.
3. Select `SWA.WF.Services.Api` in the Package Manager Console.
4. Run `Update-Database` to create the Identity database tables.
5. Set `SWA.WF.Services.Api` as the startup project.
6. Run the application.

### Frontend

```bash
cd src/SWA.WF.UI/client
npm install
npm start
```

The Angular application was originally served at `http://localhost:4200/`.

Because this project preserves its original dependency versions, modern development environments may require compatibility adjustments.

## Project context

Created as a practical full-stack challenge involving external API consumption, backend architecture, authentication, caching and frontend integration. The repository is kept close to its original implementation to document the technologies and engineering practices I was applying at that stage of my career.

---

**William Figueiredo**  
Software Engineering → AI Engineering
