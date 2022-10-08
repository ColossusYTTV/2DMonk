
using BepInEx;
using UnityEngine;

namespace Colossal
{
    [BepInPlugin("org.ColossusYTTV", "2DMonk", "1.0.0")]
    public class Main : BaseUnityPlugin
    {
        private void OnEnable()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            HarmonyPatches.RemoveHarmonyPatches();
        }

        public bool Done;
        private void Update()
        {
            if (!Done)
            {
                Done = true;
                GameObject monk = GameObject.Find("Player");
                monk.transform.position = new Vector3(0.2f, 1, -5);

                GameObject.Find("Level").transform.localScale = new Vector3(0.05f, 1, 1);
                GameObject.Find("Global").transform.localScale = new Vector3(0.05f, 1, 1);
            }
            else
            {
                Done = false;
            }
        }
    }
}