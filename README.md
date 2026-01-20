🌌 Eclipsera
A Mathematical Simulation of Celestial Bodies

Visual Programming Semester Project

Eclipsera is a web-based astronomical simulation and visualization system developed as part of the Visual Programming (VP) course. The project represents planetary motion and relative distances using mathematical calculations and interactive visualization, helping convert abstract celestial concepts into a clear and engaging experience.

Instead of static diagrams, Eclipsera uses time-driven simulation to show how planetary distances change over time.

✨ Why Eclipsera?

Astronomy concepts are often difficult to understand due to lack of interactivity.
Eclipsera solves this problem by:

Replacing static diagrams with dynamic, time-based visualization

Connecting mathematics with visual programming concepts

Making celestial mechanics easier to understand for students

🚀 Features
User Features

Select month and year for simulation

Calculate Earth-to-planet distances using mathematical models

View results in tabular and visual comparison formats

Observe animated planetary orbits

Clean, responsive, and beginner-friendly interface

System Features

Role-based access (Admin / User)

Secure session handling

Application-wide state management

Client-side execution for smooth performance

🧮 Mathematical and Scientific Concepts

Kepler’s Laws of Planetary Motion

Simplified orbital mechanics

Astronomical Unit (AU) based distance calculations

Time-based planetary position modeling

🏗️ Architecture Overview

Eclipsera follows a component–service architecture:

Components handle user interface and interaction

Services perform planetary calculations and core logic

A centralized state container stores session data, logs, and results

All computations are performed client-side using WebAssembly, ensuring fast and responsive interaction.

🛠️ Technology Stack

Framework: Blazor WebAssembly

Language: C# (.NET)

UI Framework: Bootstrap

Styling and Animation: CSS3

Runtime: WebAssembly

IDE: Visual Studio 2022

🧪 Testing Highlights

Valid and invalid login scenarios

Edge-case date inputs (past and future years)

Repeated and empty calculations

Unauthorized access attempts to admin panel

All test cases produced expected results without runtime errors.

🎓 Learning Takeaways

This project helped strengthen understanding of:

Visual Programming principles

Mathematical simulation design

Component-based application development

State management and dependency injection

Converting theoretical concepts into interactive systems

📂 Project Structure (Overview)
Eclipsera/
├── Components/
├── Pages/
├── Services/
├── State/
├── wwwroot/
├── App.razor
└── Program.cs

📈 Future Enhancements

Integration with real astronomical datasets

3D visualization using WebGL

Database-backed user accounts

Exportable reports and graphs

Advanced simulation controls

⚙️ How to Run the Project

Clone the repository:

git clone https://github.com/sana7au/eclipsera.git


Open the project in Visual Studio 2022

Restore dependencies (if required)

Run the project using Blazor WebAssembly

👥 Authors

Developed as a semester project during the BS Computer Science program as part of the Visual Programming course.