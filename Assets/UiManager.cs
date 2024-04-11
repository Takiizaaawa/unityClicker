using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text goldText;
    public TMP_Text clickDamageText;

    private void Update()
    {
        goldText.text = "Gold: " + Player.Instance.gold.ToString("0");
        clickDamageText.text = "Click Damage: " + Player.Instance.clickDamage.ToString("0");
    }
}

