# ICU-Tech Authentication System

## Description
Single-page authentication system with login and registration functionality using Bootstrap and SOAP web service integration.

## Features
- Login page with real-time validation
- Registration page with form validation
- Toast notifications for success/error messages
- Cross-browser and mobile responsive
- SOAP API integration

## Technologies
- ASP.NET Core 9.0
- Bootstrap 5
- System.ServiceModel (SOAP client)
- Vanilla JavaScript

## Setup Instructions

### Prerequisites
- .NET 9 SDK
- ASP.NET Runtime 9.0

## Project Structure
```
IcuTechLogin/
├── Controllers/
│   └── AuthController.cs       # API endpoints
├── Models/
│   ├── LoginRequest.cs
│   └── RegisterRequest.cs
├── Services/
│   └── IcuTechSoapClient.cs   # SOAP client
├── wwwroot/
│   ├── index.html             # Login page
│   └── render.html            # Registration page
└── Program.cs
```

## API Endpoints
- POST `/api/auth/login` - User login
- POST `/api/auth/register` - User registration
