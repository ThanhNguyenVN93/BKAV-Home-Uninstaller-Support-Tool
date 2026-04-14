# BKAV Home Uninstaller Support Tool

A lightweight Windows desktop utility to detect and safely uninstall BKAV Home antivirus software from your system.

## Table of Contents

- [Features](#features)
- [System Requirements](#system-requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Supported Operating Systems](#supported-operating-systems)
- [Building from Source](#building-from-source)
- [License](#license)
- [Support](#support)

## Features

✅ **BKAV Home Detection** - Automatically detects BKAV Home installation status
✅ **Safe Uninstallation** - Launches official BKAV Home uninstaller
✅ **System Information** - Displays OS version and architecture
✅ **Auto-exit Countdown** - Automatically closes after 5 seconds if BKAV not detected
✅ **Real-time Clock** - Shows current system date and time
✅ **User-friendly UI** - Simple and intuitive Windows Forms interface
✅ **Donation Support** - Built-in option to support development

## System Requirements

- **Windows XP or later**
- **.NET Framework 4.6 or higher**
- **Administrator privileges** (recommended for uninstallation)
- **Internet Explorer 6+** (for some functionality)

## Installation

1. Download the latest release from the [Releases](../../releases) page
2. Extract the executable to your desired location
3. Run `frmbkavhome.exe`
4. The tool will automatically start

**Note**: Administrator privileges may be required to complete the uninstallation process.

## Usage

### Basic Workflow

1. **Launch the Tool**
   - Run `frmbkavhome.exe`

2. **Check Installation Status**
   - The tool automatically checks if BKAV Home is installed
   - Status is displayed at the top of the window

3. **Uninstall BKAV Home** (if installed)
   - Click the **Remove** button
   - Follow the official BKAV Home uninstaller prompts
   - Complete the uninstallation process

4. **Clean Up Leftover Files**
   - Click the **Delete Leftover** button to remove remaining files
   - Or close the application using **Exit** button

### If BKAV Home is Not Detected

- The application will automatically close after a 5-second countdown
- You can manually close it at any time using the **Exit** button

## Supported Operating Systems

| OS | Status |
|---|---|
| Windows XP | ✅ Supported |
| Windows Server 2003 | ✅ Supported |
| Windows Vista | ✅ Supported |
| Windows 7 | ✅ Supported |
| Windows 8/8.1 | ✅ Supported |
| Windows 10 | ✅ Supported |
| Windows 11 | ✅ Supported |
| 32-bit Systems | ✅ Supported |
| 64-bit Systems | ✅ Supported |

## Building from Source

### Prerequisites

- Visual Studio 2015 or later
- .NET Framework 4.6 or higher
- C# language support

### Steps

1. Clone the repository
   ```bash
   git clone https://github.com/yourusername/frmbkavhome.git
   cd frmbkavhome
   ```

2. Open the solution in Visual Studio
   ```
   frmbkavhome.sln
   ```

3. Build the solution
   - Press `Ctrl+Shift+B` or go to `Build` → `Build Solution`

4. Run the application
   - Press `F5` or click the Start button

## Project Structure

```
frmbkavhome/
├── Form1.cs                 # Main application form
├── Form1.Designer.cs        # Designer-generated code
├── frmdonate.cs             # Donation form
├── Program.cs               # Application entry point
├── frmbkavhome.csproj       # Project file
├── frmbkavhome.sln          # Solution file
├── README.md                # This file
├── LICENSE                  # MIT License
└── RELEASE.md              # Release notes
```

## Key Components

### Form1.cs
- Main user interface
- BKAV Home detection logic
- Uninstallation process management
- System information retrieval using WMI
- Auto-exit countdown functionality

### frmdonate.cs
- Donation support dialog
- Community contribution interface

## Technical Details

- **Language**: C#
- **Framework**: .NET Framework 4.6
- **UI Framework**: Windows Forms
- **Architecture**: 32-bit and 64-bit compatible
- **System Queries**: Windows Management Instrumentation (WMI)

## Troubleshooting

### BKAV Home Not Detected

- Ensure BKAV Home is installed at the default location: `C:\Program Files (x86)\BkavHome\`
- Check if the installation path has changed on your system
- Verify administrator privileges

### Uninstallation Fails

- Run the application with administrator privileges
- Ensure BKAV Home uninstaller exists at `C:\Program Files (x86)\BkavHome\BkavHomeUnst.exe`
- Check for conflicting processes

### System Information Not Displaying

- Ensure Windows Management Instrumentation (WMI) is enabled
- Check your user account permissions
- Try running with administrator privileges

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## Support & Feedback

- **Issues**: Report bugs or request features via [GitHub Issues](../../issues)
- **Discussions**: Join our community discussions
- **Email**: Contact for direct support

## Changelog

See [RELEASE.md](RELEASE.md) for detailed version history and release notes.

---

**Made with ❤️ for the Windows community**
