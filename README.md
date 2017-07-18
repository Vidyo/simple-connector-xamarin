# simple-connector-xamarin

## Clone Repository
git clone https://github.com/Vidyo/simple-connector-xamarin.git

## Acquire VidyoClient library
1. Create a directory called 'lib' in the root directory of where this repository was cloned (i.e. parallel to this README.md file) and two directories underneath 'lib': 'ios' and 'android'.
2. Download the latest Vidyo.io iOS SDK package: https://static.vidyo.io/latest/package/VidyoClient-iOSSDK.zip
3. Copy the framework located at VidyoClient-iOSSDK/lib/ios/VidyoClientIOS.framework to the 'lib/ios' directory.
4. Download the latest Vidyo.io Android SDK package: https://static.vidyo.io/latest/package/VidyoClient-AndroidSDK.zip
5. Copy all files located at VidyoClient-AndroidSDK/lib/android to the 'lib/android' directory.

## Overview
The solution contains four projects: VidyoClientIOS (bindings library), VidyoClientAndroid (bindings library), SimpleVidyoConnectorIOS (iOS application project), SimpleVidyoConnectorAndroid (Android application project)

## Build and Run Application
1. Open the solution SimpleVidyoConnector.sln in Xamarin Studio version 6.3 or later.
2. Set either SimpleVidyoConnectorIOS or SimpleVidyoConnectorAndroid as the Startup Project, depending on which type of device you want to load the application to.
3. Set a valid token in either SimpleVidyoConnectorIOS/ViewController.cs or SimpleVidyoConnectorAndroid/MainActivity.cs (search for text "INSERT VALID TOKEN"). See the Token section of the Documentation at https://vidyo.io for more info on generating tokens.
4. Connect an iOS or Android device to the computer via USB.
5. Select the iOS or Android device as the build target of the application.
6. Build and run the application on the iOS or Android device.

