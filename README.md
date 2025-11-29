# Evoke - Windows Forms Application

A modern Windows Forms application built with C# and .NET Framework 4.8, featuring a sleek UI powered by Guna.UI2 components.

## 📋 Table of Contents

- [Features](#features)
- [Requirements](#requirements)
- [Installation](#installation)
- [Project Structure](#project-structure)
- [Dependencies](#dependencies)
- [Building the Project](#building-the-project)
- [Usage](#usage)
- [License](#license)

## ✨ Features

- **Modern UI Design**: Beautiful, dark-themed interface with smooth animations
- **Animated Background**: Custom animated dots control for visual appeal
- **License Authentication**: License key-based authentication system
- **Loading Screen**: Animated progress bar during initialization
- **Settings Interface**: Toggle switches for various configuration options
- **Serial Checker**: Hardware serial number verification interface

## 🔧 Requirements

- **.NET Framework 4.8** or higher
- **Visual Studio 2019** or later (recommended)
- **Windows OS** (Windows 7 or later)

## 📦 Installation

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd WindowsFormsApp17
   ```

2. Restore NuGet packages:
   ```bash
   nuget restore
   ```
   Or open the solution in Visual Studio and let it restore packages automatically.

3. Build the solution:
   ```bash
   msbuild WindowsFormsApp17.sln /p:Configuration=Release
   ```
   Or build from Visual Studio (Build → Build Solution).

## 📁 Project Structure

```
WindowsFormsApp17/
├── Form1.cs              # Main login form
├── Form1.Designer.cs      # Login form designer
├── Form3.cs              # Main application form
├── Form3.Designer.cs     # Main form designer
├── Dots.cs               # Custom animated dots control
├── Dots.Designer.cs      # Dots control designer
├── Program.cs            # Application entry point
├── Properties/           # Application properties and resources
├── Resources/            # Image resources
└── packages.config       # NuGet package references
```

## 📚 Dependencies

The project uses the following NuGet packages:

- **Guna.UI2.WinForms** (v2.0.4.6) - Modern UI component library
- **Newtonsoft.Json** (v13.0.3) - JSON serialization library
- **System.Runtime.Serialization.Primitives** (v4.3.0) - Serialization primitives

## 🏗️ Building the Project

### Using Visual Studio

1. Open `WindowsFormsApp17.sln` in Visual Studio
2. Select your desired build configuration (Debug/Release)
3. Press `F5` to build and run, or `Ctrl+Shift+B` to build only

### Using Command Line

```bash
# Debug build
msbuild WindowsFormsApp17.sln /p:Configuration=Debug

# Release build
msbuild WindowsFormsApp17.sln /p:Configuration=Release
```

The compiled executable will be in:
- Debug: `WindowsFormsApp17/bin/Debug/WindowsFormsApp17.exe`
- Release: `WindowsFormsApp17/bin/Release/WindowsFormsApp17.exe`

## 🚀 Usage

1. Run the application executable
2. Enter your license key in the login screen
3. Click "Sign In" to proceed
4. Wait for the loading screen to complete
5. Use the main interface to configure settings and access features

## 🎨 Custom Components

### Dots Control

The `Dots` control is a custom animated background component that displays rising dots with fade-in/fade-out effects. It's configurable through properties:

- `DotCount`: Number of dots displayed
- `DotSpeed`: Animation speed
- `DotSize`: Size of individual dots
- `DotColor`: Color of the dots
- `BackgroundColor`: Background color
- `AnimationFPS`: Animation frame rate
- `FadeInDuration`: Fade-in duration in frames
- `FadeOutDuration`: Fade-out duration in frames

## ⚠️ Important Notes

- This application requires administrator privileges for certain hardware-related operations
- Ensure all dependencies are properly installed before running
- The application uses custom UI components from Guna.UI2 - ensure licenses are properly configured

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📧 Support

For issues, questions, or contributions, please open an issue on the GitHub repository.

---

**Note**: This application is provided as-is for educational and development purposes. Use responsibly and in accordance with applicable laws and regulations.

