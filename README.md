# 📚 Telli Raflar — Library Management System (C#)

A comprehensive library automation system built with C# and Object-Oriented 
Programming principles. Developed with AI-assisted code review (Gemini AI) 
as a technical consultant throughout the process.

---

## ✨ Features

- 👥 **Membership Tiers** — Silver, Gold, Diamond with different privileges
- 📖 **Smart Borrowing System** — Auto-calculates return dates based on membership type
- 💰 **Balance Management** — Real-time member balance and transaction tracking
- 📦 **Inventory Management** — Add books and magazines via donation system
- 🔐 **Session Simulation** — Dynamic user profile with recent transactions
- 🛡️ **Defensive Programming** — Try-catch blocks prevent all invalid inputs

---

## 🏗️ Architecture & OOP Concepts

| Concept | Implementation |
|--------|---------------|
| **Inheritance** | `GumusUye` → `AltinUye` → `ElmasUye` hierarchy |
| **Polymorphism** | Overridden `uyelikUcreti()` per membership type |
| **One-to-Many** | Member ↔ BorrowedBooks relationship |
| **Encapsulation** | Private fields with controlled access methods |

---

## 🛠️ Tech Stack

- **Language:** C#
- **Platform:** .NET Console Application
- **AI Assisted:** Gemini AI (Code Review & Architecture)
- **IDE:** Visual Studio

---

## 🚀 How to Run

1. Clone the repository
```bash
git clone https://github.com/arda-portakalkoku/Telli-Raflar-Kutuphane-Otomasyonu.git
```
2. Open in Visual Studio
3. ⚠️ **Main class is located inside `UyelikSecenekleri` folder**
4. Run the project (F5)

---

## 💡 What Makes This Project Special

This project was built not just to write code, but to simulate a **real 
business system.** Every feature reflects an actual library workflow — 
from membership upgrades to overdue tracking.

Using AI as a **code reviewer** (not a code generator) helped me understand
architectural decisions at a deeper level.

---

## 📂 Project Structure
```
Telli-Raflar/
│
├── UyelikSecenekleri/    ← Main class here
│   ├── Program.cs
│   ├── GumusUye.cs
│   ├── AltinUye.cs
│   └── ElmasUye.cs
│
└── README.md
```

---

## 👨‍💻 Author

**Arda Portakalkökü** — MIS Student & Developer  
🌐 [Portfolio](http://ardaportakalkoku.com) · 
📝 [Blog](https://ardacodes.blogspot.com) · 
💼 [LinkedIn](https://www.linkedin.com/in/arda-portakalkökü-1020472b4)
