using Modding;
using System.Collections.Generic;
using UnityEngine;

namespace RomanExtras
{
    public class RomanExtras : Mod, ITogglableMod
    {
        public RomanExtras() : base("Roman Extras")
        {
            ModHooks.LanguageGetHook += OnLanguageGetHook;
        }

        
        public override string GetVersion() => "1.0";

        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
        {
            Log("Roman Extras Mod Initialized");
        }

        private string OnLanguageGetHook(string key, string sheet, string orig)
        {
            if (key == "MAIN_EXTRAS")
            {
                return "Roman Extras";
            }
            return orig;
        }

        public void Unload()
        {
            ModHooks.LanguageGetHook -= OnLanguageGetHook;
            Log("Roman Extras Mod Unloaded. Restart the game to see changes.");
        }
    }
}
