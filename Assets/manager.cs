using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 
public class manager : MonoBehaviour
{
    public TMP_Text ClicksTotalText; 

    float TotalClicks;


    public void Addclicks(){
        TotalClicks++; 
        ClicksTotalText.text= TotalClicks.ToString("0");
    }
}


