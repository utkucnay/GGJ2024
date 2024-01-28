using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public Image image;

    private void Awake()
    {
        var seq = DOTween.Sequence();
        seq.Append(image.DOFade(1, .6f).SetEase(Ease.InOutBack));
        seq.Append(image.DOFade(0, .6f).SetEase(Ease.InOutBack));
        seq.AppendCallback( () => 
        {
            SceneManager.LoadScene("MainMenuScene");
        });
    }
}
