using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkUpMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SaveDataButton()
    {
        Debug.Log("Pressed");
        MarkUpManager.instance.SaveMarkupData();
    }
   
}
