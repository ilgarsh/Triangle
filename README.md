# Triangle App

The mobile app gets 3 numbers and outputs the type of the triangle.
Written in Xamarin.Forms.
### Platforms:
- Android
- UWP

### Autotests:

- [For Android (Xamarin UITest)](###-Run-Android-autotests)
- [For UWP (Appium + Windows Application Driver)](###-Run-UWP-autotests)

### Run Android autotests
1. Download Android SDK
2. Set enviroment variable ANDROID_HOME = path_to_sdk
3. Write path to apk in variable ApkPath (AppInitializer.cs)  `// ugly`

### Run UWP autotests
1. Download WinAppDriver from https://github.com/Microsoft/WinAppDriver/releases
2. Run WinAppDriver.exe

### Problems
- Support for two testing frameworks for Android and UWP (duplication of test cases)