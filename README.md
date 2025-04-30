# ShadowKey - Secure Data Transmission in Cloud-Based

<p align="center">
  <img src="https://raw.githubusercontent.com/TNAlotaibi/ShadowKey/refs/heads/main/ShadowKeyLogo.PNG" width="250" alt="Project Logo">
</p>

ShadowKey is an open-source application for secure messaging that combines steganography (hiding messages in images) with strong encryption to provide private communication. Users can embed secret messages within image files and share them securely through cloud storage and email.

## Features

- **Secure Message Encoding**: Hide secret messages within image files using steganography
- **AES Encryption**: Protect messages with 128/192/256-bit AES encryption
- **Tamper Detection**: MD5 hashing verifies message integrity
- **Cloud Integration**: Secure file sharing via Dropbox API
- **Email Notifications**: Automatic email alerts with decryption keys
- **User Authentication**: Secure login and registration system
- **Modern UI**: Clean Material Design interface with light/dark themes

## Limitations

While ShadowKey provides robust security, there are some current limitations:

1. **Single-message constraint**: Only one hidden message can be sent per recipient at a time
2. **Third-party dependencies**: Requires Dropbox and SMTP services to be operational
3. **Message size limits**: Maximum message capacity depends on the carrier image dimensions
4. **Setup complexity**: Manual configuration of API tokens and email credentials needed
5. **Platform restriction**: Currently available only for Windows OS
6. **No message history**: Doesn't maintain conversation logs or sent message archives


## How It Works

1. **Encoding Process**:
   - User selects an image and enters a secret message
   - Application encrypts the message with AES
   - Encrypted message is embedded in the image using steganography
   - Hash of original message is generated for integrity checking
   - Protected image is uploaded to recipient's Dropbox folder
   - Recipient receives email with decryption key and hash

2. **Decoding Process**:
   - Recipient downloads protected image from Dropbox
   - Application extracts encrypted message from image
   - Message is decrypted using provided key
   - Hash is verified to ensure message wasn't tampered with

## Requirements

### Development Requirements
- .NET Framework 4.7.2 or later
- Visual Studio 2019+
- NuGet packages:
  - MaterialSkin.2
  - Dropbox.Api
  - System.Drawing.Common

### Runtime Requirements
- Windows 10/11
- .NET Desktop Runtime 4.7.2+
- Dropbox API token (in `token.txt`)
- SMTP email credentials (for notifications)
  

## 📜 Intellectual Property

### Project Ownership
This project ("ShadowKey") was developed as a graduation project
## 👥 Team Members

<table>
  <tr>
    <td align="center">
      <a href="https://github.com/Hmcys">
        <img src="https://avatars.githubusercontent.com/Hmcys" width="100px;" alt=""/>
        <br />
        <sub><b>Hatem Alotaibi</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/daxksa">
        <img src="https://avatars.githubusercontent.com/daxksa" width="100px;" alt=""/>
        <br />
        <sub><b>Emad (Dax)</b></sub>
      </a>
    </td>
     <br/>
      <td align="center">
      <a href="https://github.com/mgeed0">
        <img src="https://avatars.githubusercontent.com/mgeed0" width="100px;" alt=""/>
        <br />
        <sub><b>Majed Alhafi</b></sub>
      </a>
    </td>
      <br/>
      <td align="center">
      <a href="https://github.com/">
        <img src="https://avatars.githubusercontent.com/" width="100px;" alt=""/>
        <br />
        <sub><b>Faris Alotaibi</b></sub>
      </a>
    </td>
  </tr>
</table>
