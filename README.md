# MAUI-JustifyLabel
 
Justify label for MAUI

Provides the ability to justify the text in a Label via attached property or by using a custom control.

[![NuGet version (MAUI-JustifyLabel)](https://img.shields.io/nuget/v/JustifyLabel-MAUI.svg)](https://www.nuget.org/packages/JustifyLabel-MAUI/)


### Windows
![Sample](https://raw.githubusercontent.com/Jon2G/MAUI-JustifyLabel/main/screenshots/windows.PNG)

### Android
![Sample](https://raw.githubusercontent.com/Jon2G/MAUI-JustifyLabel/main/screenshots/android_1.PNG)
![Sample](https://raw.githubusercontent.com/Jon2G/MAUI-JustifyLabel/main/screenshots/android_2.PNG)

### iOS
![Sample](https://raw.githubusercontent.com/Jon2G/MAUI-JustifyLabel/main/screenshots/ios.jpeg)

### MacCatalysis
![Sample](https://raw.githubusercontent.com/Jon2G/MAUI-JustifyLabel/main/screenshots/mac.png)


### Usage:
### Attached property
```
xmlns:justifiedLabel="clr-namespace:JustifyLabel;assembly=JustifyLabel"
```

```
 <Label
     justifiedLabel:Label.JustifyText="True"
     Text="Some text" />
```

### Custom control

On MauiProgram.cs
```
   var builder = MauiApp.CreateBuilder();
   builder
       .UseMauiApp<App>()
       .UseJustifiedLabel() //Add this line
       .ConfigureFonts(fonts =>
       {
           fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
           fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
       });
```

```
xmlns:justifiedLabel="clr-namespace:JustifyLabel;assembly=JustifyLabel"
```

```
<justifiedLabel:JustifiedLabel
    JustifyText="True"
    Text="Some text" />
```