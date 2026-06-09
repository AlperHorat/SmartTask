# SmartTask 🚀
A Clean Architecture-based Task Management API built with .NET 5

SmartTask is a modular and scalable backend system designed to demonstrate real-world software architecture principles such as Clean Architecture, CQRS, MediatR, Repository Pattern, and JWT-based Authentication/Authorization. It simulates a simplified project/task management system similar to Jira or Trello.

---

## 🧠 Architecture Overview

This project strictly follows Clean Architecture principles, ensuring separation of concerns, scalability, and testability.

SmartTask.API → Presentation Layer (ASP.NET Core Web API)  
SmartTask.Application → Business Logic Layer (CQRS, MediatR, DTOs, Validation, Auth)  
SmartTask.Domain → Core Business Entities & Rules  
SmartTask.Persistence → EF Core, Repositories, Database Access  
SmartTask.Infrastructure → External Services (JWT, Security, Extensions)

---

## 🔄 Domain Model

User  
└── Projects  
    └── Tasks  

Each Task belongs to a Project and can optionally be assigned to a User.

---

## ⚙️ Key Design Patterns

- Clean Architecture  
- CQRS (Command Query Responsibility Segregation)  
- Mediator Pattern (MediatR)  
- Repository Pattern  
- Dependency Injection  
- JWT Authentication & Authorization  
- Role-based Access Control (User / Admin)  
- FluentValidation  
- Global Exception Handling  

---

## 🧩 Features

### 👤 User Module
- User Registration  
- User Login  
- JWT Token Generation  
- Role-based Identity (User/Admin)

### 📁 Project Module
- Create Project  
- Get All Projects  

### ✅ Task Module
- Create Task  
- Get All Tasks  
- Get Tasks by Project  
- Task–Project relationship  
- Task assignment to users  
- Task status management (Todo / InProgress / Done)

### 🔐 Security
- JWT Authentication  
- Role-based Authorization  
- Swagger JWT Integration  
- Protected Endpoints ([Authorize])

---

## 🧪 Testing

- Unit tests for authentication flows  
- Login & JWT generation tests  
- Task creation workflow tests  
- Repository interaction validation (mocked tests)

---

## 🛠️ Tech Stack

- .NET 5  
- ASP.NET Core Web API  
- Entity Framework Core  
- PostgreSQL  
- MediatR  
- FluentValidation  
- Swagger  
- xUnit  
- Moq  

---

## 🗄️ Database Design

User (1) ─── (N) Projects  
Project (1) ─── (N) Tasks  
User (1) ─── (N) Assigned Tasks  

---

## 🚀 Getting Started

Clone repository:
git clone https://github.com/AlperHorat/SmartTask.git

Update connection string in appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=SmartTaskDb;Username=postgres;Password=your_password"
}

Run migrations:
Add-Migration InitialCreate  
Update-Database  

Run project:
dotnet run --project SmartTask.API  

---

## 📡 API Documentation

/swagger

---

## 📌 Project Status

✔ Completed:
- Clean Architecture setup  
- CQRS + MediatR pipeline  
- User, Project, Task modules  
- JWT Authentication system  
- Role-based authorization  
- Swagger JWT integration  
- Unit tests for core flows  
- PostgreSQL integration  

---

## 🧠 Engineering Focus

- Scalable backend architecture  
- Separation of concerns  
- Secure authentication & authorization  
- Maintainable and testable codebase  
- Real-world backend design patterns  

---

## 👨‍💻 Author

Built by: Alper Horat  
GitHub: https://github.com/AlperHorat
