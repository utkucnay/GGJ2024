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
        float ratio = (float)GoldManager.instance.gold / TurnManager.instance.GetMaxGoldReq();
        slider.value = ratio;
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
