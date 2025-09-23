# netProyect

## Instalar .NET en Linux
### Actualizar maquina
```
sudo apt update && sudo apt upgrade -y
```

### Instalar repositorio de Microsoft
```
wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
```

### Instalar el SDK de .NET
```
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0
```

### Verificar instalación
```
dotnet --version
```


## Crear un proyecto de consola helloworld
```
dotnet new console -n HelloWorldApp
cd HelloWorldApp
```

## Ejecutar proyecto
```
dotnet run
```

