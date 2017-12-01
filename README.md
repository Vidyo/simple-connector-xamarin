# simple-connector-xamarin

## Clone Repository
git clone https://github.com/Vidyo/simple-connector-xamarin.git

## Overview
The SimpleVidyoConnector solution contains two projects:
1. SimpleVidyoConnectorAndroid : a Xamarin.Android application containing a simple Vidyo.io integration
2. SimpleVidyoConnectorIOS     : a Xamarin.iOS application containing a simple Vidyo.io integration

## Acquire VidyoClient iOS and Android SDKs
1. Download the latest Vidyo.io iOS SDK package: https://static.vidyo.io/latest/package/VidyoClient-iOSSDK.zip
2. Move the unzipped VidyoClient-iOSSDK folder to the simple-connector-xamarin directory.
3. Download the latest Vidyo.io Android SDK package: https://static.vidyo.io/latest/package/VidyoClient-AndroidSDK.zip
4. Move the unzipped VidyoClient-AndroidSDK folder to the simple-connector-xamarin directory.

> Note: SDK version 4.1.18.8 or later is required

## Build and Run Application
1. Open SimpleVidyoConnector.sln in either Visual Studio or Xamarin Studio version 6.3 or later.
2. Set either SimpleVidyoConnectorAndroid or SimpleVidyoConnectorIOS as the Startup Project, depending on which type of device you want to load the application to.
3. Set a valid token in either SimpleVidyoConnectorIOS/ViewController.cs or SimpleVidyoConnectorAndroid/MainActivity.cs (search for text "INSERT VALID TOKEN"). See the Token section of the Documentation at https://vidyo.io for more info on generating tokens.
4. Connect an iOS or Android device to the computer via USB.
5. Select the iOS or Android device as the build target of the application.
6. Build and run the application on the iOS or Android device.

