# PointerMover

## Quick description

Little WinForms application that moves the mouse pointer back and forth every X seconds.

## Installation

### Pre-requisites

For the program to run, the `.NET Desktop Runtime` is required.

- If **NOT installed**, the following message will appear:

  !["Missing NET Desktop message"](/media/MissingNETDesktop.png)

- In that case, install it following these instructions:

  - Download it from this URL: ["Download .NET 7.0 Desktop Runtime"](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-7.0.4-windows-x64-installer?cid=getdotnetcore)

  - Launch the installation, click `Install`:

    !["Launch installation"](/media/NETDesktopInstall.png)

  - Accept the defaults settings and prompts, click `Yes`:

    !["Accept UAC message"](/media/AcceptUAC.png)

  - Success screen looks like this, click `Close`:

    !["Success screen"](/media/NETDesktopInstall-Success.png)

### Pointer Mover installation

1. Download the ZIP file from the GitHub release: ["PointerMover_v1.0.0.zip"](https://github.com/embergershared/PointerMover/blob/main/releases/download/PointerMover_v1.0.0.zip)

    !["Download"](/media/PointerMover-ZIPDL.png)

2. Extract/Unzip the folder and its content:

    !["Extract1"](/media/PointerMover-Extract1.png)

3. Select a destination on your computer:

    !["Extract2"](/media/PointerMover-Extract2.png)

4. Launch (double-click) the `PointerMover.exe` file in the folder:

    !["Extract3"](/media/PointerMover-Extract3.png)

5. Select your language and time interval, then click the `Start` / `Demarrer` / `Comecar` button:

    !["Launch1"](/media/PointerMover-Launch1.png)

6. Program runs:

    !["Launch2"](/media/PointerMover-Launch2.png)

7. Stop it with `Stop` / `Arreter` / `Parar`

8. Quit with `Quit` / `Quitter` / `Desistir`

9. Create a shortcut on your desktop with:

    1. Select the `PointerMover.exe` file, then right-click

        !["Shortcut1"](/media/PointerMover-Shortcut1.png)

    2. Select `Send to > Desktop (create shortcut)`

        !["Shortcut2"](/media/PointerMover-Shortcut2.png)

    3. Launch the program from the shortcut on the Desktop

        !["Shortcut3"](/media/PointerMover-Shortcut3.png)

## Features

- The pointer will move back and forth each selected interval (in seconds),

- Intervals are by 5 seconds increment and can range from 5 seconds to 1800 seconds (30 minutes),

- If the pointer has moved since last move by the Pointer Mover, it won't be moved. It allows the user to use the pointer without being disrupted by the Pointer Mover

- The interface is available in 3 languages:

  - US English (code `en-US` - fallback),
  - France French (code `fr-FR`),
  - Portuguese Brazilian (code `pt-BR` - start default),

  The starting language can be changed in the `appsettings.json` file.

## Uninstall

1. Delete the Folder where all the files are,

2. Eventually, delete the ZIP file,

3. Eventually, delete the shortcut on the desktop.