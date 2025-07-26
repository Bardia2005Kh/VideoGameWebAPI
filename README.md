# VideoGameAPI 🎮

A RESTful Web API built with ASP.NET Core for managing video game records.  
The project demonstrates full CRUD operations using **Entity Framework Core**, connected to a **SQL Server** database via Migrations and a custom `DbContext`.  
It also includes **Swagger (Scalar UI)** for interactive API documentation and testing.

---

## 🚀 Features

- Create new video game records (POST)
- Read all games (GET)
- Read a specific game by ID (GET /{id})
- Update existing games (PUT)
- Delete games (DELETE)
- Interactive API testing with **Swagger UI (Scalar)**

---

## 🛠 Tech Stack

- ASP.NET Core Web API
- C#
- SQL Server
- Entity Framework Core (Code First + Migrations)
- Swagger / Scalar UI
- Visual Studio 2022

---

## ⚙️ How to Run

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/VideoGameAPI.git
   cd VideoGameAPI
"ConnectionStrings": {
  "DefaultConnection": "Your-SQLServer-Connection-String"
