using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : Singleton<GameCanvas>
{
    public Canvas gameCanvas;
    public GameObject temp;

    public void SetCanvasActive(bool active)
    {
        gameCanvas.enabled = active;
    }
}
