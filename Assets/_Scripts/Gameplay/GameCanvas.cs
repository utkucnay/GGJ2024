using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameCanvas : Singleton<GameCanvas>
{
    public Canvas gameCanvas;
    public GameObject temp;

    public TextMeshProUGUI dayText;
    public TextMeshProUGUI reqGoldText;

    public int i = 0;

    public void SetCanvasActive(bool active)
    {
        gameCanvas.enabled = active;
    }

    public void NextDay() 
    {
        dayText.text = "Day " + ++i;
    }

    public void SetReqGold(int regGold) 
    {
        reqGoldText.text = regGold.ToString();
    }
}
