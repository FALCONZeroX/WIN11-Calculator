<div id="english"></div>

<div align="right">
  <a href="#english">🇬🇧 English</a> | <a href="#arabic">🇸🇦 العربية</a>
</div>

<div align="center">
  <h1>🧮 WINDOWS 11 Calculator</h1>
  <p><em>A sleek, modern, and highly responsive Windows 11 Calculator clone built with C# and WinForms.</em></p>

  <!-- Shields.io Badges -->
  <p>
    <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
    <img src="https://img.shields.io/badge/.NET_8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 8" />
    <img src="https://img.shields.io/badge/Windows_Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white" alt="WinForms" />
    <img src="https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge" alt="MIT License" />
  </p>
</div>

---

## 📑 Table of Contents
- [Features](#-features)
- [Screenshots](#-screenshots)
- [Tech Stack](#-tech-stack)
- [Project Structure](#-project-structure)
- [Key Code Highlights](#-key-code-highlights)
- [Getting Started](#-getting-started)
- [Roadmap](#-roadmap)
- [Contributing](#-contributing)
- [License & Author](#-license--author)

---

## ✨ Features
- **🎨 Pixel-Perfect Fluent UI:** Carefully crafted UI to match the native Windows 11 design language, including custom borders and button hover effects.
- **🌗 Dynamic Theming:** Seamlessly toggle between Light and Dark modes with real-time UI updates.
- **📱 Responsive Layout:** Form elements scale fluidly when the application window is resized.
- **🔢 Advanced Math Engine:** Accurately handles standard arithmetic, floating-point operations, and division by zero exceptions.
- **⌨️ Keyboard Support:** Fully mapped keyboard shortcuts for rapid calculations without a mouse.

---

## 📸 Screenshots

| ☀️ Light Mode | 🌙 Dark Mode |
| :---: | :---: |
| <img src="https://via.placeholder.com/400x500.png?text=Light+Mode+Screenshot" width="400" alt="Light Mode"/> | <img src="https://via.placeholder.com/400x500.png?text=Dark+Mode+Screenshot" width="400" alt="Dark Mode"/> |
| *Clean, bright interface for daytime use.* | *Eye-friendly dark aesthetics for low-light environments.* |

*(Note: Replace the placeholder image links above with your actual repository image paths).*

---

## 🛠️ Tech Stack

| Component | Technology / Tool |
| --- | --- |
| **Primary Language** | C# 12 |
| **Framework** | .NET 4.8 |
| **UI Platform** | Windows Forms (WinForms) |
| **IDE** | Visual Studio 2026 |
| **Architecture** | Event-Driven / Object-Oriented (OOP) |

---

## 📂 Project Structure

```text
WIN11-Calculator/
├── SimpleCalculator/
│   ├── Properties/              # Assembly info, resources, and settings
│   ├── frmCalc.cs               # Core logic, math engine, and event handlers
│   ├── frmCalc.Designer.cs      # Auto-generated UI components and layout
│   └── Program.cs               # Application entry point and bootstrapping
├── README.md                    # Project documentation (You are here)
└── WIN11-Calculator.sln         # Visual Studio Solution file

```

---

## 💻 Key Code Highlights

### 🌗 Dynamic Theme Switching

A snippet demonstrating how the application safely loops through form controls to update colors dynamically without needing an application restart.

```csharp
private void ApplyTheme(bool isDarkMode)
{
    Color backColor = isDarkMode ? Color.FromArgb(32, 32, 32) : Color.WhiteSmoke;
    Color foreColor = isDarkMode ? Color.White : Color.Black;
    
    this.BackColor = backColor;
    
    foreach (Control ctrl in this.Controls)
    {
        if (ctrl is Button btn)
        {
            btn.BackColor = isDarkMode ? Color.FromArgb(50, 50, 50) : Color.White;
            btn.ForeColor = foreColor;
            // Additional Fluent UI border logic here...
        }
    }
}

```

---

## 🚀 Getting Started

### Prerequisites

* [Visual Studio 2022](https://visualstudio.microsoft.com/) (with .NET desktop development workload).
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or higher.

### Installation

1. **Clone the repository:**
```bash
git clone [https://github.com/FALCONZeroX/WIN11-Calculator.git](https://github.com/FALCONZeroX/WIN11-Calculator.git)

```


2. **Navigate to the project directory:**
```bash
cd WIN11-Calculator

```


3. **Open the solution:**
Double-click `WIN11-Calculator.sln` to open it in Visual Studio.
4. **Build and Run:**
Press `F5` or click the **Start** button in Visual Studio to build and launch the application.

---

## 🗺️ Roadmap

* [x] Standard Calculator Mode
* [x] Light / Dark Theme Toggle
* [ ] Scientific Calculator Mode (Trigonometry, Logarithms)
* [ ] Programmer Mode (Hex, Bin, Dec, Oct)
* [ ] History Panel tracking past equations

---

## 🤝 Contributing

Contributions, issues, and feature requests are welcome!

1. Fork the Project.
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`).
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the Branch (`git push origin feature/AmazingFeature`).
5. Open a Pull Request.

---

## 📜 License & Author

Distributed under the **MIT License**. See `LICENSE` for more information.

**Developed with ❤️ by Falah Fathel**

* GitHub: [@FALCONZeroX](https://www.google.com/search?q=https://github.com/FALCONZeroX)

# 🧮 WIN11-Calculator

*تطبيق آلة حاسبة عصري، سريع الاستجابة، ومطابق لتصميم آلة حاسبة Windows 11، مبرمج بلغة C# وبيئة WinForms.*

## ✨ أهم الميزات

* **🎨 واجهة مستخدم دقيقة (Fluent Design):** تم تصميم الواجهة بعناية لتطابق لغة تصميم ويندوز 11 مع مؤثرات التمرير.
* **🌗 الوضع الليلي والنهاري:** إمكانية التبديل السلس بين الوضع الفاتح والداكن.
* **📱 تصميم متجاوب:** تتكيف أبعاد الأزرار بسلاسة عند تغيير حجم النافذة.
* **🔢 محرك عمليات دقيق:** يعالج العمليات الحسابية الأساسية بدقة عالية مع معالجة أخطاء القسمة على صفر.

## 🚀 كيفية التشغيل

1. قم بتحميل المشروع باستخدام الأمر: `git clone https://github.com/FALCONZeroX/WIN11-Calculator.git`
2. افتح ملف الحل `WIN11-Calculator.sln` باستخدام برنامج **Visual Studio 2022**.
3. اضغط على `F5` لتشغيل المشروع.

**تم التطوير بواسطة: (Falah Fathel)**

حساب جيتهب: [@FALCONZeroX](https://www.google.com/search?q=https://github.com/FALCONZeroX)
