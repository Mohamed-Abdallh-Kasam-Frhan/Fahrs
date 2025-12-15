# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a **College Management System** built with **C# Windows Forms (.NET Framework 4.5)** and **SQLite** database. The application is written primarily in Arabic (RTL interface) and manages students, teachers, and courses for a college.

**Technology Stack:**
- C# Windows Forms (WinForms)
- .NET Framework 4.5
- SQLite (System.Data.SQLite v1.0.119.0)
- Visual Studio 2013 project format

## Building and Running

### Build the Project
```bash
msbuild "Collage Management System.sln" /p:Configuration=Debug
```

### Run the Application
```bash
"Collage Management System/bin/Debug/Collage Management System.exe"
```

Or open the solution in Visual Studio and press F5.

## Project Architecture

### Entry Point
- **Program.cs**: Application entry point, launches `loginForm` on startup
- **Login**: Hard-coded credentials: username `moh`, password `123` (see SignUpandLogin/Form1.cs:41)

### Core Components

**Database Layer (Database.cs)**
- Singleton SQLite connection pattern
- Database file: `mydb.sqlite` in the working directory
- Two main methods:
  - `Database.query(string)`: Returns `DataTable` for SELECT queries
  - `Database.execute(string)`: Executes INSERT/UPDATE/DELETE
- `initDatabase()`: Creates schema and seeds initial data (currently commented out in login form)

**Main Application (MainForm.cs)**
- Central hub with three main sections accessible via sidebar buttons:
  - Students Management (إدارة الطلاب)
  - Teachers Management (إدارة المدرسين)
  - Courses Management (إدارة المقررات)
- Dynamic content switching using `switchPage()` method
- Search functionality with `btnSearch_Click()` (MainForm.cs:146)

**UI Architecture Pattern**
The application uses a **UserControl-based plugin pattern**:
- Each entity (Student/Teacher/Course) has a dedicated folder with CRUD UserControls
- MainForm dynamically loads UserControls into panels based on user actions
- `switchContent()`: Switches main content panel
- `switchInputForm()`: Switches input form panel (right sidebar)

### Database Schema

**students** table:
- id (INTEGER PRIMARY KEY)
- name, major, phone, status (VARCHAR)
- level (INTEGER)
- remainingMoney (INTEGER)

**teachers** table:
- id (INTEGER PRIMARY KEY)
- name, phone, subject, degree, salary (VARCHAR)

**cources** table (note: typo in original code):
- name, department, level, teacher, hour (VARCHAR)

**majors** table:
- id (INTEGER PRIMARY KEY)
- name (VARCHAR) - e.g., 'SE', 'IT', 'CND'

### User Control Organization

**UserControlsStudent/** - Student operations:
- UserControlStudent: Display students in DataGridView
- UserControlCreate: Add new student
- UserControlUpdate: Edit student
- UserControlDelete: Remove student
- UserControPayment: Process student payments

**userControlsTeacher/** - Teacher operations:
- UserControlTeacher: Display teachers
- UserControlCreateTecher: Add teacher (note: typo "Techer")
- UserControlUpdateTeacher: Edit teacher
- UserControlDeleteTeachercs: Remove teacher

**usercontrolCourse/** - Course operations:
- UserControlCourse: Display courses
- UserControlAddCourse: Add course
- UserControlUpdateCourse: Edit course
- UserControlDeleteCourse: Remove course

### UI Helpers (UIHelper.cs)

Static utility class for UI styling:
- `MakeButtonsRounded(Control, int)`: Applies rounded corners to all buttons
- `MakeTextBoxRounded(Control, int)`: Applies rounded corners to all text boxes
- `ApplyRoundedRegion(Control, int)`: Applies rounded corners to any control
- Recursively processes child controls

### Important Notes

1. **Database Initialization**: The `initDatabase()` call is commented out in the login form (Form1.cs:25). Uncomment and run once to create the database schema if starting fresh.

2. **SQL Injection Vulnerability**: Search functionality uses string interpolation (MainForm.cs:155). Consider using parameterized queries for production.

3. **Namespace Inconsistency**: Main namespace is `Collage_Management_System` but MainForm uses namespace `Fahrs`. Both are used throughout the codebase.

4. **RTL Interface**: The UI is designed for Arabic (right-to-left). MessageBox calls use `MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign`.

5. **No Unit Tests**: This project does not include a test suite.

6. **File Naming**: Note inconsistent casing: "usercontrolCourse" vs "UserControlsStudent" vs "userControlsTeacher"
