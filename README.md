# 🧮 WINDOWS 11 Calculator

![C#](https://img.shields.io/badge/Language-C%23-blue.svg)
![Framework](https://img.shields.io/badge/Framework-.NET%20Framework%20%2F%20.NET%208-purple.svg)
![Platform](https://img.shields.io/badge/Platform-Windows-0078D6.svg)
![UI](https://img.shields.io/badge/UI-WinForms%20%7C%20Fluent%20Design-00A4EF.svg)
![License](https://img.shields.io/badge/License-MIT-green.svg)

تطبيق حاسبة متطور ومصمم بلغة **C#** وبيئة **Windows Forms (WinForms)**، محاكي لتصميم حاسبة **Windows 11** الحديث بأسلوب أنيق وواجهة مستخدم عصرية (Fluent Design) ودعم كامل للوضع الداكن والفاتح (Dark & Light Mode).

---

## 📸 لقطات من التطبيق (Screenshots)

<div align="center">

| الوضع الداكن (Dark Mode) | الوضع الفاتح (Light Mode) |
| :---: | :---: |
| ![Dark Mode](screenshots/dark_mode.png) | ![Light Mode](screenshots/light_mode.png) |

</div>

---

## ✨ المميزات الرئيسية (Key Features)

* **🎨 تصميم محاكي لويندوز 11 (Windows 11 Fluent UI):**
  * زوايا حواف ناعمة ومنحنية باستغلال عناصر تحكم مخصصة (Custom Round Buttons).
  * شريط عنوان مخصص بدون حواف تقليدية (Custom Frameless Window Titlebar).
  * إمكانية سحب وتحريك النافذة بسلاسة عبر الأحداث `MouseDown` و `MouseMove`.

* **🌙 دعم الوضع الداكن والفاتح (Dynamic Dark / Light Mode):**
  * تبديل فوري وديناميكي لجميع ألوان العناصر والأيقونات بدقة عالية وفقاً للوضع المختار.

* **🔢 كافة العمليات الحسابية الأساسية والمتقدمة:**
  * **العمليات الأربعة الأساسية:** الجمع (`+`)، الطرح (`-`)، الضرب (`×`)، القسمة (`÷`).
  * **العمليات المتقدمة:**
    * المقلوب ($1/x$)
    * التربيع ($x^2$)
    * الجذر التربيعي ($\sqrt{x}$)
    * النسبة المئوية (%)
    * عكس الإشارة ($\pm$)
  * **التحكم والمسح:**
    * `C` (Clear All): إعادة ضبط الحاسبة بالكامل وتصفير المتغيرات.
    * `CE` (Clear Entry): مسح القيمة الحالية في خانة المدخلات.
    * `⌫` (Backspace): حذف أحدث رقم تم إدخاله.

* **🛠️ معالجة الأخطاء والقيود الرقمية (Robust Validation):**
  * منع إدخال أكثر من نقطة عشرية واحدة في الرقم نفسه (`CheckIfThereMoreThanOneDot`).
  * منع تنفيذ العمليات الحاسوبية عند عدم وجود مدخلات صحيحة (`EmptyNumberValidation`).

---

## 🛠️ التقنيات المستخدمة (Tech Stack)

* **اللغة:** C#
* **الإطار:** .NET Framework / .NET Desktop
* **واجهة المستخدم:** Windows Forms (WinForms)
* **المكتبات والأدوات:**
  * `RoundButton` Custom Control للزر المستدير.
  * `System.Drawing` للمعالجة الديناميكية للألوان والأيقونات والـ Themes.

---

## 📁 هيكلية المشروع (Project Structure)


```

WIN11-Calculator/
├── SimpleCalculator/
│   ├── Properties/
│   │   └── Resources.resx         # الأيقونات والصور المرفقة للوضعين الداكن والفاتح
│   ├── frmCalc.cs                 # المنطق البرمجي الرئيسي للحاسبة (Code-Behind)
│   ├── frmCalc.Designer.cs        # تصميم واجهة Form واختيار الأزرار والـ Panels
│   └── Program.cs                 # نقطة بداية التطبيق (Main Entry Point)
├── README.md                      # توثيق المشروع
└── WIN11-Calculator.sln           # ملف الحل الخاص بـ Visual Studio

```

---

## 💻 مقتطفات من الكود (Code Highlights)

### 1. التبديل الديناميكي بين الثيمات (Dark & Light Theme Switching)

```csharp
void DarkMode()
{
    colored = true;
    btnStyleMode.Image = Resources.DarkMode;
    pnlCalcBody.BackColor = Color.FromArgb(36, 36, 36);
    
    // ضبط ألوان الأزرار والنصوص للوضع الداكن
    lbl_Operations.ForeColor = Color.White;
    lbl_Result.ForeColor = Color.White;
    fbtnEqual.BackColor = Color.FromArgb(76, 194, 255);
    // ...
}

```

### 2. سحب النافذة المخصصة (Custom Window Dragging)

```csharp
private void pnlOutControls_MouseMove(object sender, MouseEventArgs e)
{
    if (move == 1)
        this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
}

```

---

## 🚀 كيفية التشغيل (Getting Started)

### المتطلبات الأساسية (Prerequisites)

* بيئة تطوير **Visual Studio 2022** أو أحدث.
* مثبت حزمة **.NET Desktop Development**.

### خطوات التشغيل:

1. قم بعمل `Clone` للمستودع:
```bash
git clone [https://github.com/FALCONZeroX/WIN11-Calculator.git](https://github.com/FALCONZeroX/WIN11-Calculator.git)

```


2. افتح ملف `WIN11-Calculator.sln` بواسطة Visual Studio.
3. اضغط على `F5` أو زر **Start** لتشغيل التطبيق.

---

## 👤 المطور (Author)

* **Falah Fathel (FALCONZeroX)**
* **GitHub:** [@FALCONZeroX](https://github.com/FALCONZeroX)

---

## 📄 الترخيص (License)

هذا المشروع مرخص بموجب رخصة **MIT** - راجع ملف [LICENSE](https://www.google.com/search?q=LICENSE) للتفاصيل.

```

```
