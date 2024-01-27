using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TourUI : Singleton<TourUI>
{
    RectTransform rectTransform;

    public Image turnTag;
    public Image turnCloseTag;
    public Image turnFinish;

    LinkedList<GameObject> turns = new();
    int index;

    public override void Awake()
    {
        base.Awake();
        rectTransform = GetComponent<RectTransform>();  
    }

    public void CreateTurnUI()
    {
        var size = rectTransform.sizeDelta;
        size.x = 11 * (TurnManager.instance.GetTurnCount() + 1);
        rectTransform.sizeDelta = size;

        for (int i = 0; i < TurnManager.instance.GetTurnCount(); i++) 
        {
            turns.AddLast(Instantiate(turnTag.gameObject, this.transform));
        }
        turns.AddLast(Instantiate(turnFinish.gameObject, this.transform));

        index = 0;
    }

    public void NextTurnEvent() 
    {
        var go = turns.ElementAt(index++);
        var image = go.GetComponent<Image>();
        image.sprite = turnCloseTag.sprite;
    }

    public void DestroyUI()
    {
        foreach (var turn in turns)
        {
            Destroy(turn.gameObject);
        }
        turns.Clear();
    }
}
