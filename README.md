# PointerMover

## Quick description

Little WinForms application that moves the mouse pointer back and forth every X seconds.

## Installation

### Pre-requisites

For the program to run, the `.NET Desktop Runtime` is required.

- If **NOT installed**, the following message will appear:

  !["Missing NET Desktop message"](/media/MissingNETDesktop.png)

- To install it:

  - Download it from this URL: ["Download .NET 7.0 Desktop Runtime"](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-7.0.4-windows-x64-installer?cid=getdotnetcore)

  - Launch the installation

    !["Launch installation"](/media/NETDesktopInstall.png)

  - Accept the defaults settings and prompts

    !["Accept UAC message"](/media/AcceptUAC.png)

  - Success screen looks like:

    !["Success screen"](/media/NETDesktopInstall-Success.png)

### Pointer Mover installation

1. Download the ZIP file from the GitHub release: ["Release 1.0.0 zip"]()

    !["Download"](/media/PointerMover-ZIPDL.png)

2. Extract/Unzip the folder and its content:

    !["Extract1"](/media/PointerMover-Extract1.png)

    !["Extract2"](/media/PointerMover-Extract2.png)

3. Launch (double-click) the `PointerMover.exe` file in the folder:

    !["Extract3"](/media/PointerMover-Extract3.png)

4. Select your language and time interval:

    !["Launch1"](/media/PointerMover-Launch1.png)

5. Click `Start` / `Demarrer` / `Comecar` button

    !["Launch2"](/media/PointerMover-Launch2.png)

## Features

- The pointer will move back and forth each selected interval (in seconds),

- Intervals are by 5 seconds increment and can range from 5 seconds to 1800 seconds (30 minutes),

- If the pointer has moved since last move by the Pointer Mover, it won't be moved. It allows the user to use the pointer without being disrupted by the Pointer Mover

- The interface is available in 3 languages:

  - US English (code `en-US` - fallback),
  - France French (code `fr-FR`),
  - Portuguese Brazilian (code `pt-BR` - start default),

  The starting language can be changed in the `appsettings.json` file.
