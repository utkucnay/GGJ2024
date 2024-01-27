using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldManager : Singleton<GoldManager>
{
    public TextMeshProUGUI textGold;
    public int gold;

    private void Update()
    {
        textGold.text = gold.ToString();
    }
}