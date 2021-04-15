using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
using UnityEngine.EventSystems;
using System;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    // Example script that spawns a prefab at the pointer hit location.
    [AddComponentMenu("Scripts/MRTK/Examples/SpawnOnPointerEvent")]
    public class SpawnOnPointerEvent : MonoBehaviour
    {
        public GameObject PrefabToSpawn;

        [SerializeField]
        private NonNativeKeyboard keyboard;

        private void OnEnable()
        {
            keyboard.OnClosed += DisableKeyboard;
        }

        public void Spawn(MixedRealityPointerEventData eventData)
        {
            if (PrefabToSpawn != null)
            {
                var result = eventData.Pointer.Result;
                Instantiate(PrefabToSpawn, result.Details.Point, Quaternion.LookRotation(result.Details.Normal));
            }
        }

        public void ShowKeyboard(MixedRealityPointerEventData eventData)
        {
            keyboard.PresentKeyboard();
        
        }


        private void DisableKeyboard(object sender,EventArgs eventargs) 
        {
            keyboard.OnClosed -= DisableKeyboard;
            keyboard.Close();
        }

    }
}