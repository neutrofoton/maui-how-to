# MauiHowTo

## Installation
1. Install .net SDK from 
```
https://dotnet.microsoft.com/en-us/download
https://dotnet.microsoft.com/en-us/download/dotnet/6.0
```

2. Install .NET MAUI workload with the dotnet CLI. A .NET "workload" is a collection of packs
``` bash
$ sudo dotnet workload install maui
```
or

``` bash
$ sudo dotnet workload install maui --source https://api.nuget.org/v3/index.json
```

3. Verify and install missing components with maui-check command line utility.
``` bash
$ sudo dotnet tool install -g redth.net.MAUI.check
$ sudo maui-check
```

## Command
1. Create MAUI App using Terminal command
``` bash
$ dotnet new maui -n "MauiHello"
```

   
2. Build/Run MAUI app using terrminal command
``` bash
$ dotnet build -t:Run -f net6.0-ios -p:_DeviceName=:v2:udid=F2DC88C0-7936-465C-A444-22190CED478B
```

## Tips:
1. To check simulator UDID:
   Open XCode > Window > Devices and Simulators. 
   For Simulator, Open Simulator Tab


2. To add existing Maui Project to an existing Solution for multiproject purpose:
``` bash
$ dotnet sln MauiHowTo.sln add Maui01Hello/Maui01Hello.csproj
``` 

