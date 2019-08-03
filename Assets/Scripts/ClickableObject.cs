using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickableObject : MonoBehaviour
{
    
    public void SetColorBlack()
    {
        GetComponent<Text>().color = Color.black;
    }
    
    public void SetOldColor()
    {
        GetComponent<Text>().color = new Color(222, 178, 0);
    }
}

