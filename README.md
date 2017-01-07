# GameOne

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

## Prerequisites

What things you need to install the software and how to install them

```
JDK
Windows OS
Unity 3D version > 5.5 
Android SDK
Text editor
```

## Installing

------------------------------------------------------
###HOW TO SET THE ENVIRONMENT FOR A ANDROID GAME IN UNITY
------------------------------------------------------

1. INSTALL JAVA

	Go to the java site and download the most recent JDK

	Download e run the installer

	Add the environment variables




2. INSTALL THE ANDROID SDK TOOLS

	Go to the android developer site

	Download the Android SDK Tools ('the command line tools', NOT the full Android Studio)

	Unzip the file and remember the location - will be used on Unity

	Open the directory tha contains the Android SDK Tools and navigate to tools

	Click the file called android to run it

	If the device you’re building to runs the latest version of Android, you don’t need to select anything else. If the device you’re building to runs an earlier version of Android, scroll down the list of packages and select the version you need.

	Click Install [x] packages to start the installation process.

	When the installation process has completed, close the window.




-----------------------------------------
###HOW TO SETUP GITHUB WITH AN UNITY PROJECT
-----------------------------------------

Create a New Repository window, select the owner of the repo (this will probably just be you)

Put in a repository name. E.G: MyUnityGame.

Put in a Description if you want.

Set it to public or private (If you’re on a free account you can only choose public).

Check the box that says “Initialize this repository with a README”

Click the “Add .gitignore” box. On the filter box that comes up, type “Unity”. You will see a Unity option come up in the list, choose this option

Click “Create Repository”

Open up the Unity Project that you want to setup for use with GitHub and go to Edit à Project Settings → Editor

From the “Version Control” drop down box, choose “Visible Meta Files”. 

From the “Asset Serialization” drop down, choose “Force Text”


------------------------------------------
###HOW TO BUILD THE GAME TO AN ANDROID DEVICE
------------------------------------------



1. PREPARING YOUT UNITY PROJECT FOR BUILDING TO ANDROID

	Within Unity, open the Build Settings from the top menu (File > Build Settings).
	
	Highlight Android from the list of platforms on the left and choose Switch Platform at the bottom of the window.
	Open the Player Settings in the Inspector panel (Edit > Project Settings > Player).
	
	Expand the section at the bottom called Other Settings, and enter your chosen bundle identifier where it says Bundle identifier.(NAME OF THE GAME)
	
	Using the top menu, navigate to Unity > Preferences (on OSX) or Edit > Preferences (on Windows).
	
	When the Preferences window opens, navigate to External Tools.
	
	Where it says Android SDK Location, click Browse, navigate to where you put the directory containing Android SDK Tools and click Choose.




2. PREPARING YOUR ANDROID DEVICE

	On your Android device, navigate to Settings > About phone or Settings > About tablet.
	
	Scroll to the bottom and then tap Build number seven times. A popup will appear, confirming that you are now a developer.
	
	Now navigate to Settings > Developer options > Debugging and enable USB debugging.




3. BUILDING AN ANDROID PROJECT USING UNITY

	Connect your Android device to your computer using a USB cable.

	You may see a prompt asking you to confirm that you wish to enable USB debugging on the device. If so, click OK.

	In Unity, open the Build Settings from the top menu (File > Build Settings).

	Click Add Open Scenes to add the Main scene to the list of scenes that will be built.

	Click Build And Run.

	Create a directory called "Builds" in the root of your project (not within your Assets directory, but at the same level as it).

	Select that directory as the location to build to.

	In the text input field marked Save As, enter "Android" and click Save.




4. TESTING THE GAME ON YOUT ANDROID DEVICE

	With the game still running on your device, return to your computer.

	Navigate to the directory containing the Android SDK Tools.

	Navigate to tools and double click the application called monitor.
