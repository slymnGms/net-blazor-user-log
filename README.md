# Blazor WebAssembly User Registiraiton & Logging App 
Simplified .NET 5.0 Blazor App with User management using services and alerts  

## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)
* [Contact](#contact)
----------
## General info
Project is a simple .NET 5.0 Blazor Front-End application provides user management with auth and services. For preview it uses fake-backend in Helpers.

The architecture of project combined of 
* Helpers
* Services
* Models
* Alert

----------	
## Technologies
Project is created with:
* .NET version: **@5.0.5**

----------
## Setup
To run this project:

```
$ cd ../project_path
$ dotnet restore
$ dotnet run
```

Or build and run in Docker
```
$ docker build --pull --rm -f "Dockerfile" -t net-blazor-user-log:latest "." 
$ docker run --rm -d  -p 4000:4000/tcp net-blazor-user-log:latest
```

----------
## Contact
* Github : [slymnGms](https://github.com/slymnGms)
* LinkedIn: [Suleyman GUMUS](www.linkedin.com/in/sulaiman-gms)
* E-mail: [suleyman.gumus@outlook.com.tr](mailto:suleyman_gumus@outlook.com.tr)