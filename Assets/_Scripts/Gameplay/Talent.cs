using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Talent : Singleton<Talent>
{
    public int skip;
    public int reroll;

    public TextMeshProUGUI textSkip;
    public TextMeshProUGUI textReroll;

    public Button butSkip;
    public Button butReroll;

    public override void Awake()
    {
        base.Awake();

        butSkip.onClick.AddListener(() =>
        {
            skip--;
        });

        butReroll.onClick.AddListener(() =>
        {
            reroll--;
            CardManager.instance.SetCanvasActive(false);
            CardManager.instance.SetCanvasActive(true);
        });
    }

    private void Update()
    {
        butSkip.interactable = skip > 0;
        butReroll.interactable = reroll > 0;

        textSkip.text = skip.ToString();
        textReroll.text = reroll.ToString();


    }
}
