# ![secureid thumbnail][secureid-thumbnail] SecureID ![secureid badge][secureid-badge]
A Windows form application that can generate a digital ID where the ID's information is stored in an encrypted QR code. A registration form is filled out to apply for the ID. The QR code generated to the ID can then be used to verify if the ID is genuine and registered to the database.

## Table of Contents
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [License](#license)
- [Acknowledgments](#acknowledgments)

## Features
![login screen][login-screen] &nbsp;
![application form][application-form]
- **Login Screen** - The application requires a passcode provided by the authentication application.
- **Application Form** - A form that requires to be filled out using the applicant's information, a sign and a 1x1 picture

![id generation][id-generation] &nbsp;
![id verification][id-verification]
- **Encrypted ID Generation** - The generated QR code in front of the ID is encrypted and makes it unreadable with traditional QR reader applications.
- **ID Verification** - In case that ID is required to be verified first for some reason, verification can be done directly through the application.
- **Transaction Counter** - Display the number of processed transactions.

## Usage
1. The application has a registration form that needs to be filled out using the applicant's information, a sign and a 1x1 picture. This information will be encrypted and saved to the database for further processing.
2. The applicant will receive a transaction slip that will be used for the next step.
3. The ID provider can then print the ID on a physical card by generating the ID using the transaction slip.

> [!IMPORTANT]
> The ID contains an encrypted QR code which includes all the ID's information. This QR code can then be used to verify if the ID is genuine and registered to the database.

## Installation
1. Download the latest version of [SecureID][release-page].
2. Install [SecureID-0.1.0-Alpha.exe][latest-release].

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments
- **[Visual Studio 2022][visual-studio-2022]**: For development environment.
- **[Windows Forms][windows-forms]**: For graphical user interface.
- **[Advanced Installer][advanced-installer]**: For installer.
- **[Otp.NET][otp-net]**: For two-factor authentication.
- **[Newtonsoft.Json][newtonsoft-json]**: For JSON serializer.
- **[AForge.Video.DirectShow][aforge-video-directshow]**: For video sources access library.
- **[QRCoder][qrcoder]**: For QR code generator.

<!-- Reference -->
[secureid-thumbnail]: https://github.com/AHG-BSCS/PIYU_SecureID/assets/130748576/730d3ac8-3227-4f49-83d9-5813e746b531
[secureid-badge]: https://img.shields.io/badge/Windows-Digital_ID_Management_System-1D923D

[login-screen]: https://github.com/AHG-BSCS/PIYU_SecureID/assets/130748576/5e2d3933-a4a1-4041-90f7-5cf0304c348d
[application-form]: https://github.com/AHG-BSCS/PIYU_SecureID/assets/130748576/5af4ed17-e198-4a50-af13-d1a96079aec2
[id-generation]: https://github.com/AHG-BSCS/PIYU_SecureID/assets/130748576/0286c9fc-b8f7-4332-8886-76c89bd731c7
[id-verification]: https://github.com/AHG-BSCS/PIYU_SecureID/assets/130748576/67beb747-7b36-4eb3-87f0-aa80f43eea95

[release-page]: https://github.com/AHG-BSCS/PIYU_SecureID/releases
[latest-release]: https://github.com/AHG-BSCS/PIYU_SecureID/releases/download/v0.1.0-Alpha/SecureID-0.1.0-Alpha.exe
[visual-studio-2022]: https://learn.microsoft.com/en-us/visualstudio/ide/?view=vs-2022
[windows-forms]: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-8.0
[advanced-installer]: https://www.advancedinstaller.com/user-guide/using.html
[otp-net]: https://github.com/kspearrin/Otp.NET
[newtonsoft-json]: https://www.newtonsoft.com/json/help/html/Introduction.htm
[aforge-video-directshow]: https://www.aforgenet.com/framework/
[qrcoder]: https://github.com/codebude/QRCoder/wiki
