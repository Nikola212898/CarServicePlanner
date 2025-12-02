# CarServicePlanner
ASP.NET Core MVC application for vehicle maintenance planning.
# 🚗 CarServicePlanner  

![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-8.0-blue?logo=dotnet)
![C#](https://img.shields.io/badge/C%23-Programming-green?logo=csharp)
![Entity Framework Core](https://img.shields.io/badge/EF_Core-8.0-lightblue?logo=database)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-purple?logo=bootstrap)
![SQL Server](https://img.shields.io/badge/SQL_Server-LocalDB-red?logo=sqlserver)
![GitHub](https://img.shields.io/badge/Hosted_on-GitHub-black?logo=github)
A modern ASP.NET Core MVC application for organizing vehicle information, tracking service history, and planning future maintenance.



---

## 📌 Overview

**CarServicePlanner** is a lightweight but fully functional vehicle management system built with ASP.NET Core MVC and Entity Framework Core.  
It allows users to:

- Register and manage multiple cars  
- Record past service actions  
- Track mileage and vehicle details  
- Plan upcoming services  
- View a dashboard with quick navigation  
- Work with a clean, modern, Bootstrap-based UI  

This project is designed as a **portfolio-ready showcase** for junior .NET developers, demonstrating practical skills in full-stack web development.

---

## 🖼️ Screenshots

> Below is a visual overview of the application.  
> *(Screenshots are located in the `/screenshots` folder inside the repository.)*

### **Dashboard**
![Dashboard](screenshots/dashboard.png)

### **Cars list**
![Cars list](screenshots/cars_list.png)

### **Car details**
![Car details](screenshots/car_details.png)

### **Add new car**
![Add car](screenshots/car_create.png)

### **Edit car**
![Edit car](screenshots/car_edit.png)

### **Upcoming services**
![Upcoming services](screenshots/upcoming_services.png)

### **Service history**
![Service history](screenshots/service_history.png)

### **Add service**
![Add service](screenshots/service_create.png)

### **Service details**
![Service details](screenshots/service_details.png)

### **Delete service**
![Delete service](screenshots/service_delete.png)

---

## 🛠️ Technologies Used

### **Backend**
- ASP.NET Core MVC 8.0  
- C#  
- Entity Framework Core (Code-First)  
- SQL Server / LocalDB  

### **Frontend**
- Bootstrap 5  
- Custom CSS (background image, card layout, shadows)  

### **Tools**
- Visual Studio 2022  
- Git & GitHub  
- EF Core Migrations  

---

## ✨ Features

### **1. Car Management**
- Add, edit, delete vehicles  
- Track brand, model, year, mileage, VIN, notes  
- Set next service date (with validation — no past dates)  
- Fully styled Create/Edit forms  

### **2. Service History**
- Add service records linked to a specific car  
- Track service date, type, cost, notes, mileage at service  
- Validation to prevent future service dates  
- View service history directly on the car's Details page  

### **3. Upcoming Services**
A dedicated page showing all cars with upcoming service deadlines:
- Days left indicators (Today / 1 day / X days)  
- Direct links to Edit and Details  

### **4. Home Dashboard**
Minimal, modern Home page with quick navigation cards:
- Cars  
- Upcoming Services  
- Service History  

### **5. Modern UI**
- Custom background image (fixed, full-screen)  
- Transparent content-wrapper cards  
- Clean typography and consistent Bootstrap styling  
- Responsive layout  

---

## ▶️ How to Run the Project

### **1. Clone the repository**
```bash
git clone https://github.com/USERNAME/CarServicePlanner.git
cd CarServicePlanner
```  

### **2. Restore dependencies**
```bash
dotnet restore
```

### **3. Apply database migrations**
```bash
dotnet ef database update
```

### **4. Run the application**
```bash
dotnet run
```



💡 What I Learned

-While building this project I practiced:
-ASP.NET Core MVC project setup
-Entity Framework Core Code-First
-1-to-many relationships (Car → ServiceRecords)
-Using migrations and database updates
-Bootstrap UI design and responsive components
-Clean form layouts and validation
-Git workflow and structured commits
-Building a project ready for portfolio and interviews




📬 Contact

Developer: Nikola Cimeša
GitHub: https://github.com/Nikola212898
LinkedIn: linkedin.com/in/nikola-cimesa-967a4b39a
Email: nikolaaacimesa@gmail.com
