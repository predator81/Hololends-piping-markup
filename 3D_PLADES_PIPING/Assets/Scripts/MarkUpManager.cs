using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class MarkUpManager : MonoBehaviour
{
    public static MarkUpManager instance;
    public List < Vector3 > markUpPosition = new List < Vector3 >();
    public List<MarkUp> markUps = new List<MarkUp>();
    public Transform selectedmarkUp;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public GameObject[] FindAllMarkups()
    { 
        return GameObject.FindGameObjectsWithTag("MarkUp");

    }
    public void AddMarkup(MarkUp markUp) 
    {
        markUps.Add(markUp);
    }

    public void GetAllMarkUpPosition()
    {
        GameObject[] MarkUps = FindAllMarkups();
        foreach (var mark in MarkUps)
        {
            markUpPosition.Add(mark.transform.position);
            
        }
        for (int i = 0; i < markUpPosition.Count; i++)
        {
            Debug.Log(markUpPosition[i]);
            
        }
    }

    public void MarkUpPipeSize()
    {


        GetAllMarkUpPosition();
        for (int i = 0; i < markUpPosition.Count; i++)
        {
            // 0 replaced by pipe size from markup
            //positionAndSize.Add(markUpPosition[i], 0);

        }
        

    
    
    }


    public void SaveMarkupData()
    {
        GetAllMarkUpPosition();
        SaveData currentdata = new SaveData();
        GameObject[] MarkUps = FindAllMarkups();
        currentdata.saveMarkupPosition = markUpPosition;
        
        for (int i = 0; i < currentdata.saveMarkupPosition.Count; i++)
        {
            Debug.Log(currentdata.saveMarkupPosition[i]);


        }
        currentdata.name = "Markup Positions";
        string currentDataAsString = JsonUtility.ToJson(currentdata);
        PlayerPrefs.SetString("MarkUpPositions", currentDataAsString);
        PlayerPrefs.Save();

        string StoragePath = Application.persistentDataPath;
        File.WriteAllText(StoragePath + "/3D_PLADES_PIPING/MarkUpPosition.json", currentDataAsString);

        Debug.Log(currentDataAsString);
    }

    
}
