using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public Image image;
    public Image image1;
    public TextMeshProUGUI text;

    private void Awake()
    {
        var seq = DOTween.Sequence();
        seq.Append(image.DOFade(1, .8f).SetEase(Ease.InOutSine));
        seq.Join(image1.DOFade(1, 1f).SetEase(Ease.InOutSine));
        seq.Join(text.DOFade(1, 1.2f).SetEase(Ease.InOutSine));
        seq.AppendInterval(2f);
        seq.Append(image.DOFade(0, .6f).SetEase(Ease.InOutQuint));
        seq.Join(image1.DOFade(0, .4f).SetEase(Ease.InOutQuint));
        seq.Join(text.DOFade(0, .2f).SetEase(Ease.InOutQuint));
        seq.AppendCallback(() =>
        {
            SceneManager.LoadScene("MainMenuScene");
        });
    }
}
