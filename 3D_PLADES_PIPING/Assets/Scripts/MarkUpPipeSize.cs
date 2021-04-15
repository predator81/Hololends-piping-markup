using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkUpPipeSize : MonoBehaviour
{
    public MarkUp markUp;
    string pipeSize;
    public void LogPositionPipeSize()
    {
        markUp.position = this.transform.position;
        markUp.pipeSize = pipeSize;

        MarkUpManager.instance.AddMarkup(markUp);
    }

    public void Keyboard()
    {
        MarkUpKeyboard.instance.markUpPipeSize = this;
    }

    public void PipeSize(string Value)
    {
        pipeSize = Value;
    }
}
