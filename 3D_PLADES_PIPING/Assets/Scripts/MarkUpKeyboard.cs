using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class MarkUpKeyboard : MonoBehaviour
{
    public static MarkUpKeyboard instance;
    [SerializeField]
    private TMP_InputField inputField;
    public MarkUpPipeSize markUpPipeSize;

    public List<Button> enterButton = new List<Button>();
    private void Awake()
    {
        instance = this;
    }
    public void ConnectMarkUp()
    {
        if (inputField.text != null)
        {
            markUpPipeSize.PipeSize(inputField.text);
        }
    }

    private void Start()
    {
        for (int i = 0; i < enterButton.Count; i++)
        {

            enterButton[i].onClick.AddListener(ConnectMarkUp);
        
        
        }
    }


}
