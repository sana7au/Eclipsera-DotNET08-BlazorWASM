# 🌌 Eclipsera  
### A Mathematical Simulation of Celestial Bodies  
**Blazor WebAssembly Standalone Project**

Eclipsera is a web-based astronomical simulation and visualization system developed as part of the **Visual Programming (VP) course**. The project represents planetary motion and relative distances using **mathematical calculations and interactive visualization**, making abstract celestial concepts easier to understand.

---

## ✨ Why Eclipsera?

Traditional static diagrams fail to show how planetary distances change over time.  
Eclipsera addresses this problem by providing **time-based, dynamic visualization**, helping learners better understand celestial mechanics.

---

## 🚀 Features

### 🌍 User Features
- Select month and year for simulation  
- Calculate Earth-to-planet distances using mathematical models  
- View results in tabular and visual comparison formats  
- Observe animated planetary orbits  
- Clean and beginner-friendly interface  

### 🔐 System Features
- Role-based access (Admin / User)  
- Secure session handling  
- Application-wide state management  
- Client-side execution for smooth performance  

---

## 🧮 Mathematical Concepts Used
- Kepler’s Laws of Planetary Motion  
- Simplified orbital mechanics  
- Astronomical Unit (AU) based calculations  
- Time-based planetary position modeling  

---

## 🏗️ Architecture Overview
Eclipsera follows a component–service architecture:

- UI components handle user interaction and visualization  
- Services manage planetary calculations and logic  
- A centralized state container stores session data and results  

All computations are performed client-side using **WebAssembly**.

---

## 🛠️ Technology Stack
- **Framework:** Blazor WebAssembly  
- **Language:** C# (.NET)  
- **UI Framework:** Bootstrap  
- **Styling & Animation:** CSS3  
- **Runtime:** WebAssembly  
- **IDE:** Visual Studio 2022  

---

## 🧪 Testing
- Valid and invalid login scenarios  
- Edge-case date inputs  
- Repeated and empty calculations  
- Unauthorized admin access attempts  

---

## 🎓 Learning Outcomes
- Practical application of Visual Programming concepts  
- Mathematical simulation design  
- Component-based architecture  
- State management and dependency injection  
- Converting theory into interactive systems  

---

## 📂 Project Structure
``` bash
Eclipsera/
├── Components/
├── Pages/
├── Services/
├── State/
├── wwwroot/
├── App.razor
└── Program.cs
```

---

## ⚙️ How to Run

1. Clone the repository:
git clone: <br>
``` bash
https://github.com/sana7au/eclipsera.git
```
3. Open the project in **Visual Studio 2022**
4. Restore dependencies (if required)
5. Run the project using **Blazor WebAssembly**

---

## 📈 Future Enhancements
- Integration with real astronomical datasets  
- 3D visualization using WebGL  
- Database-backed user accounts  
- Exportable reports and graphs  

---

## 👨‍💻 Authors
Developed as a semester project during the **BS Computer Science** program for the **Visual Programming** course.
