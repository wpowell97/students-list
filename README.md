# 📘 Student Portal – ASP.NET Core 8 MVC CRUD Project

This project is a simple **Student Management Portal** built with **ASP.NET Core 8 MVC**, following the [YouTube tutorial by Amichand Ruprah](https://www.youtube.com/watch?v=_uSw8sh7xKs). It demonstrates full **CRUD functionality (Create, Read, Update, Delete)** using **Entity Framework Core** and **SQL Server**.

---

## 🛠️ Technologies Used

- ASP.NET Core 8 (MVC)
- C#
- Entity Framework Core 8
- SQL Server
- Bootstrap 5
- Visual Studio / VS Code

---

## 🚀 Features

- View all students in a list
- Add new student
- Edit existing student
- Delete student
- Server-side validation
- Razor Views with Bootstrap UI

---

## 📂 Project Structure

```
StudentPortal/
│
├── Controllers/          # MVC Controllers (StudentsController.cs)
├── Models/
│   ├── Entities/         # EF Core Entity (Student.cs)
│   └── ViewModels/       # View Models (AddStudentViewModel.cs)
├── Data/                 # DbContext (ApplicationDbContext.cs)
├── Views/
│   └── Students/         # Razor views for Add, Edit, List
├── appsettings.json      # Configuration
├── Program.cs            # Application entrypoint
└── StudentPortal.csproj  # Project file
```

---

## ⚙️ Getting Started

### 1. Clone or extract the project

```bash
git clone <repo-url>
cd "ASP 8 MVC CRUD - Student Portal/StudentPortal"
```

### 2. Restore packages

```bash
dotnet restore
```

### 3. Build the project

```bash
dotnet build
```

### 4. Run the project

```bash
dotnet run
```

### 5. Apply the database migrations

```bash
dotnet ef database update
```

---

## 🧠 Learning Outcome

This project demonstrates how to:
- Use **EF Core** for database operations
- Bind models using **ViewModels**
- Implement **data validation**
- Apply **best practices in ASP.NET Core MVC**

---

## 📺 Tutorial Credit

- 📹 [Watch the full tutorial on YouTube](https://www.youtube.com/watch?v=_uSw8sh7xKs) by Amichand Ruprah
