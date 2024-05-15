using BepInEx;

namespace FartMoon
{
    [BepInPlugin(GUID, NAME, VERSION)]
    [BepInDependency("evaisa.lethallib", "0.15.1")]
    public class Plugin : BaseUnityPlugin
    {

        const string GUID = "wexop.fartzone";
        const string NAME = "FartZone";
        const string VERSION = "1.0.3";

        public static Plugin instance;

        void Awake()
        {
            instance = this;

            Logger.LogInfo($"FartZone starting....");
        }




    }
}