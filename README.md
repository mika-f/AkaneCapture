# QuickCapture

Fast, Lightweight and Easy 2D bar-code reader for Windows.

## Why QuickCapture

QuickCapture has the following features:

- Free to use.
  - If you like this software, please send the movie tweet of kawaii move to [@MikazukiFuyuno](https://twitter.com/MikazukiFuyuno).
- Reading results of 2D bar-codes are saved permanently.
- QuickCapture can also recognize 2D bar-code displayed in the background.
  - Background is a state that is hidden from other applications.
- Support multiple displays.
  - QuickCapture captures single process, not monitors/displays.
- Support multiple bar-codes in same frame.

Basically, it assumes 2D bar-code recognition in VR spaces/worlds like VRChat.

## Requirements

- .NET Framework 4.7
- Windows 10 1903 or greater
  - \* QuickCapture uses UWP Interop API

## How to use

In this example, VRChat is configured for the target application.

### Process Detection

1. Launch QuickCapture.
2. Launch VRChat.
3. Enjoy!

### Capture

1. Stare at the 2D bar-code that you want to capture for 5 seconds.
   1. You can change the gaze time from the settings.
2. QuickCapture try to read 2D bar-code and store it.

### Test

This application has been tested in the following environments:

* VRChat (Steam) + Desktop PC (Desktop Mode)
* VRChat (Steam) + Oculus Rift S (SteamVR Mode)
* VRChat (Oculus) + Desktop PC (Desktop Mode)
* VRChat (Oculus) + Oculus Rift S (VR Mode)
