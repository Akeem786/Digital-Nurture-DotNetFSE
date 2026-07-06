# 🛒 RetailInventory — EF Core 8.0 Demo Project

A lightweight **.NET console application** demonstrating core **Entity Framework Core 8.0** concepts — from project setup to performing full CRUD-style operations on a SQLite database, all without writing a single line of raw SQL.

This project simulates a simplified **retail inventory management system**, where products are organized under categories, inserted into a database, and queried back using LINQ.

---

## 📌 Overview

EF Core acts as an **ORM (Object-Relational Mapper)** — it maps C# classes directly to database tables, allowing developers to interact with data using objects and LINQ instead of manually writing SQL queries.

This project was built to practically demonstrate that mapping in action: defining models, configuring a `DbContext`, persisting data, and retrieving it using different query strategies.

---

## 🚀 Features

- **Code-First approach** — database schema generated directly from C# model classes
- **One-to-Many relationship** between `Category` and `Product`
- **SQLite** as the underlying database (lightweight, file-based, zero server setup)
- **CRUD-style operations** — insert and retrieve data using EF Core
- Multiple **LINQ query patterns**:
  - `ToList()` — fetch all records
  - `Find()` — fetch by primary key
  - `FirstOrDefault()` — fetch with a custom condition

---

## 🧰 Tech Stack

| Component | Technology |
|---|---|
| Language | C# (.NET 10) |
| ORM | Entity Framework Core 8.0 |
| Database | SQLite |
| Project Type | Console Application |

---

## 📂 Project Structure

```
RetailInventory/
├── Program.cs              # Entry point — models, DbContext, and app logic
├── RetailInventory.csproj  # Project configuration & package references
├── retail.db                # SQLite database (auto-generated on run)
└── README.md
```

---

## 🗂 Data Model

**Category**
| Field | Type |
|---|---|
| Id | int (PK) |
| Name | string |
| Products | List\<Product\> |

**Product**
| Field | Type |
|---|---|
| Id | int (PK) |
| Name | string |
| Price | decimal |
| CategoryId | int (FK) |
| Category | Category |

---

## ⚙️ Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (10.0 or compatible)

### Setup & Run

```bash
# Clone the repository
git clone https://github.com/Akeem786/RetailInventory-EFCore.git
cd RetailInventory-EFCore

# Restore dependencies
dotnet restore

# Run the application
dotnet run
```

On first run, EF Core automatically creates a local `retail.db` SQLite file and seeds it with sample data.

---

## 📤 Sample Output

```
Laptop - ₹75000
Rice Bag - ₹1200
Found: Laptop
Expensive: Laptop
```

---

## 📚 What I Learned

- How EF Core bridges C# objects and relational database tables (ORM concept)
- Configuring `DbContext` and `DbSet<T>` for data access
- Defining relationships between entities (one-to-many)
- Performing inserts using `AddRange()` and `SaveChanges()`
- Querying data using LINQ methods: `ToList()`, `Find()`, `FirstOrDefault()`
- Using `EnsureCreated()` to auto-generate a database schema from models

---

## 🔮 Possible Enhancements

- Add full CRUD with Update/Delete operations
- Switch from `EnsureCreated()` to proper **EF Core Migrations**
- Expose this data layer through an **ASP.NET Core Web API**
- Add async operations end-to-end (`AddAsync`, `SaveChangesAsync`, `ToListAsync`)
- Write unit tests using **NUnit/Moq**

## 👤 Author

**Akeem Ali**

B.Tech CSE & IT Student

GitHub: https://github.com/Akeem786  
LinkedIn: https://www.linkedin.com/in/akeem-ali-ba8178323

---

Part of the **Cognizant Digital Nurture DotNet FSE** learning program. This repository contains my hands-on implementation of **Entity Framework Core 8.0**, covering database context configuration, migrations, CRUD operations, and data retrieval using EF Core.
