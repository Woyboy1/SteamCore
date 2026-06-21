using System.Linq;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public static AchievementManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public bool AchievementStatus(string achievementID)
    {
        if (!Steamworks.SteamClient.IsValid)
            return false;

        var achievement = new Steamworks.Data.Achievement(achievementID);
        Debug.Log($"Steamworks - Achievement Status: {achievement.State}.");

        return achievement.State;
    }

    public void UnlockAchievement(string achievementID)
    {
        if (!Steamworks.SteamClient.IsValid)
            return;

        var achievement = new Steamworks.Data.Achievement(achievementID);
        achievement.Trigger();

        Debug.Log($"Steamworks - Achievement: {achievementID} unlocked.");
    }

    public void ClearAchievement(string achievementID)
    {
        if (!Steamworks.SteamClient.IsValid)
            return;

        var achievement = new Steamworks.Data.Achievement(achievementID);
        achievement.Clear();

        Debug.Log($"Steamworks - Achievement: {achievementID} cleared.");
    }
}

// Use this static class to use for checking the achievementIDs
public static class AchievementIDs
{
    public const string OpeningCeremony = "OpenAchievement";
}