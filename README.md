<p align="center">
	<img src="Images/MincraftServerSharpLogo.png"/>
	<h3 align="center">Minecraft Server Hosting Panel / Utility</h3>
	<p align="center">But it's all free!</p>
</p>

# Features
- Automatic deployment
- Automatic server version updates
- Web Console Interface
- Web configuration / Admin panel
- Administrate / Configure all your servers at once
- Manage plugins from web panel
- REST Api interface for each server
- Dockerized container deployment; Scalability
- Discord intergeneration; Webhooks
- Track player stats


# Installation Process - Windows
Simply click the launch executable. If the software it not installed it will install automatically.  
If the software is installed it will start the server.

# Installation Process - Linux
```bash
wget https://packages.microsoft.com/config/ubuntu/21.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
```

```bash
sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y aspnetcore-runtime-5.0
```

```bash
dotnet run MinecraftServerHost.dll
```


## Donate
btc Address: 34Xj9iUK77hcaNdVCzRskhLJ5kwFCoGp9E