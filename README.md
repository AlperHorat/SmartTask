# SmartTask 🚀
A Clean Architecture-based Task Management API built with .NET 5

SmartTask is a modular and scalable backend system designed to demonstrate real-world software architecture principles such as Clean Architecture, CQRS, MediatR, and Repository Pattern. It simulates a simplified project/task management system similar to Jira or Trello.

---

## 🧠 Architecture Overview

This project strictly follows Clean Architecture principles, ensuring separation of concerns, testability, and maintainability.

SmartTask.API → Presentation Layer (ASP.NET Core Web API)  
SmartTask.Application → Business Logic (CQRS, MediatR, DTOs, Validation)  
SmartTask.Domain → Core Business Entities & Rules  
SmartTask.Persistence → EF Core, Repositories, Database Access  
SmartTask.Infrastructure → External services (extensible layer)

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
- FluentValidation (integration in progress)  
- Global Exception Handling (in progress)

---

## 🧩 Features

### 👤 User Module
- Create User  
- Get All Users  

### 📁 Project Module
- Create Project  
- Get All Projects  

### ✅ Task Module
- Create Task  
- Get All Tasks  
- Project–Task relationship  
- Task assignment to users  

---

## 🛠️ Tech Stack

- .NET 5  
- ASP.NET Core Web API  
- Entity Framework Core  
- PostgreSQL  
- MediatR  
- FluentValidation  
- Swagger  

---

## 🗄️ Database Design

User (1) ─── (N) Projects  
Project (1) ─── (N) Tasks  
User (1) ─── (N) Assigned Tasks  

---

## 🚀 Getting Started

Clone repository:
git clone https://github.com/your-username/smarttask.git

Update connection string:
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
- User module  
- Project module  
- Task module (Create & GetAll)  
- PostgreSQL integration  

🚧 In Progress:
- Validation pipeline stabilization  
- Global exception handling  
- Task business rules  

🔮 Planned:
- JWT Authentication & Authorization  
- Role-based access control  
- Task filtering & pagination  
- Docker support  
- Unit & integration tests  

---

## 🧠 Engineering Focus

- Scalable backend architecture  
- Separation of concerns  
- Real-world design patterns  
- Maintainable codebase  

---

## 👨‍💻 Author

Built by: Alper Horat  
GitHub: https://github.com/AlperHorat
