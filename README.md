# Moscovium S

![Banner](MCSB.png)

**Moscovium S** is a modern, faster, and smoother Windows debloat utility built as the successor to Moscovium 3. Designed with a focus on performance and user experience, Moscovium S provides an intuitive interface for safely removing unnecessary Windows components and bloatware.

## Features

- **Modern UI**: Built with Blazor and Windows Forms for a responsive, intuitive interface
- **Faster Performance**: Optimized debloating routines for quicker execution
- **Safe Debloating**: Carefully curated removal lists to avoid system instability
- **Advanced Tools**: Includes built-in utilities for system optimization
- **User-Friendly**: Simple one-click debloating with detailed control options
- **Windows 10/11 Compatible**: Fully tested on modern Windows versions

## Installation

### Prerequisites
- Windows 10 or later
- .NET 10.0 or higher

### Download & Run
Download the latest release from [GitHub](https://github.com/Moscoviumdebloat/Moscovium-S) and extract the executable.

## Usage

![Screenshot Placeholder](Screenshot%202026-03-03%20223423.png)

## What's New in Moscovium S

Compared to Moscovium 3, Moscovium S features:

- ✨ Completely redesigned modern interface
- ⚡ Significantly faster debloating performance
- 🎨 Enhanced visual design and responsiveness
- 🔧 Improved tool stability and reliability
- 📦 Updated removal lists and component database
- 🛡️ Better safety checks and validation

## Comparison

| Feature | Moscovium 3 | Moscovium S |
|---------|------------|------------|
| Interface | Legacy | Modern (Blazor) |
| Performance | Standard | Optimized |
| Stability | Good | Excellent |

## System Requirements

- **OS**: Windows 10/11 (21H2 or later recommended)
- **RAM**: 4GB minimum, 8GB recommended
- **Disk Space**: 200MB available
- **Permissions**: Administrator privileges required

## Configuration

Configuration files can be found in the application's data directory. Advanced users can customize:

- Debloat profiles
- Component removal lists
- Tool behavior and logging

## Troubleshooting

### Application won't start
- Ensure .NET 10.0 is installed
- Run as Administrator
- Check Windows Event Viewer for errors

### Debloating process fails
- Create a system restore point first
- Run the application as Administrator
- Check available disk space
- Review the application logs

## Support

For issues, feature requests, or contributions:

- **Original Project**: [Moscovium 3](https://github.com/Moscoviumdebloat/Moscovium)
- **This Project**: [Moscovium S](https://github.com/Moscoviumdebloat/Moscovium-S)
- **Report Issues**: GitHub Issues tab

## Contributing

Contributions are welcome! Please:

1. Fork the repository
2. Create a feature branch
3. Make your improvements
4. Submit a pull request

## License

This project is provided as-is. Review the LICENSE file for details.

## Disclaimer

Moscovium S modifies your Windows installation. While every effort has been made to ensure safety, use at your own risk. Always:

- Create a system restore point before debloating
- Back up important data
- Test on non-critical systems first

## Build Instructions

### Requirements
- Visual Studio 2022 or later
- .NET 10.0 SDK
- Windows 10/11 SDK

### Build

```bash
# Clone the repository
git clone https://github.com/Moscoviumdebloat/Moscovium-S.git
cd Moscovium-S

# Restore dependencies
dotnet restore

# Build the project
dotnet build -c Release

# Run the application
dotnet run
```

## Development

The project is structured as follows:

```
Moscovium_S/
├── Components/          # Blazor components
├── Resources/           # Resource files and assets
├── wwwroot/            # Web assets (HTML, CSS, JS)
├── Form1.cs            # Windows Forms host
├── App.razor           # Root Blazor component
└── Properties/         # Project properties
```

## Acknowledgments

Built as a modern successor to the original Moscovium 3 project, incorporating user feedback and modern development practices.

---

**Moscovium S** - Debloating Made Simple, Fast & Modern
