SteamCore
By Woyboy

Unity Version: Unity 6 (6000.0.45f1)
Facepunch Steamworks Version: 2.4.1

Features
SteamIntegration.cs
AchievementManager.cs
Facepunch.Steamworks folder (Actual implementation)
How to Install and Implement
Download the package from the GitHub repository through a UnityPackage or by downloading the entire repository. (UnityPackage recommended)
Move the package into your project's Assets folder.
Verify that you have the following folders:
Plugins
Prefabs
Scripts
In the Prefabs folder, drag and drop the ++ Steam Integration GameObject into your scene.
Open SteamIntegration.cs.
In the Start() method, insert your App ID into the following line:
Steamworks.SteamClient.Init(0000000);
Replace 0000000 with your Steam App ID.
You're done!
Other Features of SteamIntegration.cs

This script mainly handles the initialization and shutdown of Steamworks.

Methods
GetSteamName()

Returns the Steam display name.

GetPlayerSteamID()

Returns the player's Steam ID.

Example:

STEAM_0:1:12345678
How to Unlock, Clear, and Check Achievements

Both scripts follow a singleton pattern and contain a static Instance reference for easy access.

Inside AchievementManager.cs is a static class called AchievementIDs. It is recommended to store all achievement IDs there for organization.

Unlock Achievement
AchievementManager.Instance.UnlockAchievement(
    AchievementIDs.OpeningCeremony
);
Clear Achievement
AchievementManager.Instance.ClearAchievement(
    AchievementIDs.OpeningCeremony
);
Check Achievement Status
bool unlocked = AchievementManager.Instance.AchievementStatus(
    AchievementIDs.OpeningCeremony
);
Requirements
Unity 6 (6000.0.45f1)
Facepunch Steamworks 2.4.1
Steam Client running
Valid Steam App ID
