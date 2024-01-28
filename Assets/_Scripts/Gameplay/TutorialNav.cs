using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialNav : MonoBehaviour
{
    

    public void setMainScene()
    {
        
            SceneManager.LoadScene("MainMenuScene");
        }
}
