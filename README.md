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

> Note: SDK version 4.1.20.3 or later is required

## Importing VidyoClient iOS SDK
To use the VidyoClient SDK in a Xamarin.iOS app, perform the following steps:
1.  In the Solution pad, right-click on the Xamarin.iOS project and select "Add" > "Add Existing Folder".
2.  In the file-selection dialog, browse to project subdirectory "VidyoClient-iOSSDK".
3.  Click "Open" to finish the file selection.
4.  Under "Choose files to include in the project", click the checkbox to the left of "VidyoClient-iOSSDK > include > csharp" and select "OK".
5.  In the Solution pad, right-click on the Xamarin.iOS project and select "Add" > "Add Native Reference".
6.  In the file-selection dialog, browse to project subdirectory "VidyoClient-iOSSDK/lib/ios".
7.  From that directory, select all 6 static library files "lib*.a" and the framework directory "VPX.framework".
8.  Click "Open" to finish the file selection.
9.  In the Solution pad, expand the new "Native References" folder in the project; right-click "libVidyoClient"; and choose "Properties".
10. In that "Properties" pad, go to the "Frameworks" field.
11. Enter the following list of iOS frameworks from Apple:  AudioToolbox AVFoundation CoreLocation CoreMedia SystemConfiguration UIKit

> Note: the above steps are already performed in the SimpleVidyoConnectorIOS project in the SimpleVidyoConnector solution.

## Importing VidyoClient Android SDK
To use the VidyoClient SDK in a Xamarin.Android app, perform the following steps:
1. In the Solution pad, right-click on the Xamarin.Android project and select "Add" > "Add Existing Folder".
2. In the file-selection dialog, browse to project subdirectory "VidyoClient-AndroidSDK".
3. Click "Open" to finish the file selection.
4. Under "Choose files to include in the project", click the checkbox to the left of "VidyoClient-Android" and select "OK".
5. In the Solution pad, expand the new "VidyoClient-AndroidSDK/lib/android" folder in the project.
6. Right-click on "vidyoclient.jar" and choose "Properties".
7. In that "Properties" pad, go to the "Build action" field and populate it with "AndroidJavaLibrary".
8. Under each of the 4 architecture folders (arm64-v8a, armeabi-v7a, x86, x86_64), right-click "libVidyoClient.so"; and choose "Properties".
9. In that "Properties" pad, go to the "Build action" field and populate it with "AndroidNativeLibrary".

> Note: the above steps are already performed in the SimpleVidyoConnectorAndroid project in the SimpleVidyoConnector solution.

## Build and Run Application
1. Open SimpleVidyoConnector.sln in either Visual Studio or Xamarin Studio version 6.3 or later.
2. Set either SimpleVidyoConnectorAndroid or SimpleVidyoConnectorIOS as the Startup Project, depending on which type of device you want to load the application to.
3. Set a valid token in either SimpleVidyoConnectorIOS/ViewController.cs or SimpleVidyoConnectorAndroid/MainActivity.cs (search for text "INSERT VALID TOKEN"). See the Token section of the Documentation at https://vidyo.io for more info on generating tokens.
4. Connect an iOS or Android device to the computer via USB.
5. Select the iOS or Android device as the build target of the application.
6. Build and run the application on the iOS or Android device.

