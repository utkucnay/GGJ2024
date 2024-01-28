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
        seq.Append(image.DOFade(1, .8f).SetEase(Ease.InOutSine));
        seq.AppendInterval(2f);
        seq.Append(image.DOFade(0, .6f).SetEase(Ease.InOutQuint));
        seq.AppendCallback( () => 
        {
            SceneManager.LoadScene("Tutorial");
        });
    }
}
