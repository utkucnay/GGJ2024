using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Sprite lowLaugh;
    public Sprite mediumLaugh;
    public Slider slider;
    public Image sliderImage;
    public Animator laughLoop;

    private void Update()
    {
        laughLoop.enabled = false;
        float ratio = 1;
        if (TurnManager.instance.GetMaxGoldReq() != 0)
            ratio = (float)GoldManager.instance.gold / TurnManager.instance.GetMaxGoldReq();
        ratio = Math.Clamp(ratio, 0, 1);
        slider.DOValue(ratio, .2f);
        if (ratio < .35f)
        {
            sliderImage.sprite = lowLaugh;
        }
        else if (ratio < .7f)
        {
            sliderImage.sprite = mediumLaugh;
        }
        else 
        {
            laughLoop.enabled = true;
        }
    }
}
