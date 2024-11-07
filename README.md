AR project for CSPE51 Jul'24 Semester

Unity Version **2022.3.51f1** was used

Instructions for execution:
1. Paste the following in a terminal: git clone https://github.com/adithyag1/arvrwardrobe.git
2. Open the project by selecting Add > Add project from Disk > select the destination where you cloned the repository and choose 'arvrwardrobe' folder inside it
3. After opening the project, go to File > Build Settings > Player Settings
4. Click on the android symbol, go to other settings subsection
5. Uncheck Auto Graphics API
6. Remove Vulkan if present and add OpenGLES3 in the graphics APIs
7. In identification > Minimum API level choose Android 7.0 'Nougat' (Level 24)
8. Set Target API level to highest installed
9. In configuration > scripting backend select IL2CPP
10. Set API compatibility level to .NET Standard 2.1
11. Target Architectures select ARMv7 and ARM64
12. Set Active Input Handling to Both
13. Leave Player settings. In project settings, go to XR plugin management choose android button and select Google AR core.
14. Close project settings. Open Window > Package Manager
15. Choose Unity Registry from the Packages: dropdown.
16. Search and download Google ARCore XR Plugin and AR Foundation
17. Go to the project window. From Assets, Open Scenes Folder
18. Drag the TestScene into the hierarchy.
19. Delete the other default scenes that were already there.
20. Now click on File> build settings
21. Click Add Open Scenes. The TestScene will be included now.
22. Click Android symbol and select switch platform.
23. Meanwhile, enable developer mode in android phone and connect usb to laptop
24. Click on Build and Run, save the apk anywhere, preferably in project directory.
25. If you see this alert: "PlayerSettings->Active Input Handling is set to Both, this is unsupported on Android and might cause issues with input and application performance. Please choose only one active input handling. Ignore and continue? (This dialog won't appear again in this Editor session if you'll choose Yes)", Just choose Yes.

APK will open in phone, give permission for using camera.
If it doesnt open, check in the apps for a unity apk app.
After Camera opens, wait for Planes to start appearing.
Click on a plane at some distance and 3D mannequin will appear.
Using the UI buttons, chose the desired fashionItems.
Move around and the mannequin will rotate to look at the camera.
