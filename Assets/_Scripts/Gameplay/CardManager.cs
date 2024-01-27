using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : Singleton<CardManager>
{
    Canvas canvas;
    CardPool cardPool;
    public override void Awake()
    {
        base.Awake();
        canvas = GetComponent<Canvas>();
        cardPool = GetComponentInChildren<CardPool>();
    }

    public void SetCanvasActive(bool active) 
    {
        canvas.enabled = active;

        if (active)
        {
            var randCards = cardPool.GetRandomsCard();

            foreach (var randCard in randCards)
            {
                Instantiate(randCard, cardPool.transform);
            }
        }
        else 
        {
            foreach (Transform randCard in cardPool.transform)
            {
                Destroy(randCard.gameObject);
            }
        }
    }
}
