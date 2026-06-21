⧭ SteamCore
⧭ By Woyboy
➛ Unity Version: Unity 6 (6000.0.45f1)
➛ Facepunch Steamworks Version: 2.4.1

➛ Features:
SteamIntegration.cs
AchievementManager.cs
Facepunch.Steamworks folder (Actual implementation)

➛ How to Install and implement:
Download the package from the GitHub repo (duh!!) through a UnityPackage or the entire thing. (I recommend the UnityPackage)
Move the package/folders into your assets folder, if it’s outside it will not work.
To be sure you have everything, you should have 3 folders containing Plugins, Prefabs, and Scripts
In the Prefabs folder drag and drop the “++ Steam Integration” GameObject into your scene. 
Go to the scripts folder and open the SteamIntegration.cs file
In the Start() method insert your App ID inside this line of code: Steamworks.SteamClient.Init(0000000), very important
You’re done!

➛ Other Features of SteamIntegration.cs:
There are 2 simple methods you can use in this script, but this script should mainly just handle the simple integration of Steamworks in your app
GetSteamName() => returns the Steam name (not username)
GetPlayerSteamID() => returns the Steam player’s ID (ex: STEAM_0:1:12345678)




➛ How to unlock/clear/check achievements:
Both scripts follow a singleton pattern and has a static instance to easily access
Inside the AchievementManager.cs file is a static class called AchievementIDs. I recommend using it to keep an organized list of all your achievements and their IDs. 
Lastly call on AchievementManager.cs with the public methods such as 
UnlockAchievement(string achievementId)
ClearAchievement((string achievementId)
AchievementStatus((string achievementId)

