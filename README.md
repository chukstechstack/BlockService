# BlockService

A Windows Service application built with .NET Framework 4.7.2 for running background tasks and automation on Windows.

## Overview

BlockService is designed to run as a Windows Service so it can continue processing work even when no user is logged in. It is suitable for scheduled jobs, monitoring, maintenance tasks, and background automation.

## Features

- Windows Service hosting
- .NET Framework 4.7.2 compatibility
- Continuous background execution
- Easy to extend for custom business logic
- Suitable for local and server deployments

## Prerequisites

- Windows operating system
- .NET Framework 4.7.2
- Visual Studio 2022 or later
- Administrative rights for service installation and management

## Getting Started

1. Open `BlockService.slnx` in Visual Studio.
2. Restore NuGet packages if prompted.
3. Build the solution.
4. Install or run the service in the target Windows environment.

## Build

From Visual Studio:

- Build the solution in Debug or Release mode.

From the command line:

```powershell
msbuild BlockService.slnx /p:Configuration=Release
```

## Run

This project is intended to run as a Windows Service. Install it in your target environment and monitor it through Windows Service Manager and the Event Log.

## Project Notes

This service is designed for reliable background execution and can be extended to support custom operational logic, monitoring, scheduled jobs, and integration tasks.

## Troubleshooting

- Verify .NET Framework 4.7.2 is installed
- Check service permissions
- Review Windows Event Viewer
- Confirm configuration values and dependencies

## License

This project is intended for local development and deployment. Add a license file if you plan to distribute it externally.
