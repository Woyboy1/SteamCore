using UnityEngine;


/// <summary>
/// This follows a singleton pattern there should only be one
/// intializer according to Facepunch's documentation. 
/// 
/// The object should also live in a persistent scene so it is recommended
/// to place this script in a bootstrap scene, or a dedicated
/// Systems prefab to always exist.
/// </summary>
public class SteamIntegration : MonoBehaviour
{
    public static SteamIntegration Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // ------ Initalize Steamworks
    private void Start()
    {
        try
        {
            Steamworks.SteamClient.Init(1234567); // Your App ID goes here
        }
        catch (System.Exception e)
        {
            // Errors will occur if:
            /*
             * Your Steam is not open (running in the background)
             * There is no steam_api dll file in your Facepunch.Steamworks folder
             * No permission to play the app
             * You forgot to set the app ID above
             * 
             */

            Debug.Log(e);
        }
    }

    public string GetSteamName()
    {
        return Steamworks.SteamClient.Name;
    }

    public string GetPlayerSteamID()
    {
        return Steamworks.SteamClient.SteamId.Value.ToString();
    }

    private void Update()
    {
        // Recieving Steamworks information to run smoothly (ex: Steam overlay)
        Steamworks.SteamClient.RunCallbacks();
    }

    private void OnApplicationQuit()
    {
        Steamworks.SteamClient.Shutdown();
    }
}
