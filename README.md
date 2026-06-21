# SteamCore

## By Woyboy

**Unity Version:** Unity 6 (6000.0.45f1)  
**Facepunch Steamworks Version:** 2.4.1

---

## Features

- SteamIntegration.cs
- AchievementManager.cs
- Facepunch.Steamworks folder (Actual implementation)

---

## How to Install and Implement

1. Download the package from the GitHub repository through a UnityPackage or by downloading the entire repository. (UnityPackage recommended)
2. Move the package into your project's Assets folder.
3. Verify that you have the following folders:
   - Plugins
   - Prefabs
   - Scripts
4. In the Prefabs folder, drag and drop the **++ Steam Integration** GameObject into your scene.
5. Open `SteamIntegration.cs`.
6. In the `Start()` method, insert your App ID into the following line:

```csharp
Steamworks.SteamClient.Init(0000000);
```

---

## How to unlock/clear/check achievements:

1. Both scripts follow a singleton pattern and has a static instance to easily access
2. Inside the AchievementManager.cs file is a static class called AchievementIDs. I recommend using it to keep an organized list of all your achievements and their IDs. 
3. Lastly call on AchievementManager.cs with the public methods such as 
- UnlockAchievement(string achievementId)
- ClearAchievement((string achievementId)
- AchievementStatus((string achievementId)

