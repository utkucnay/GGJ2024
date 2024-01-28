using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DeckViewerManager : Singleton<DeckViewerManager>
{
    public Transform layout;
    public Canvas canvas;

    LinkedList<Card> cards = new LinkedList<Card>();
    public void SetDeckViewer()
    {
        var cards = Deck.instance.entities.Select(e => e.card).ToList();
        foreach (var card in cards)
        {
            cards.Add(Instantiate(card, layout));
        }
        canvas.enabled = true;
    }

    public void RemoveDeckViewer()
    {
        foreach (var card in cards)
        {
            Destroy(card);
        }
        canvas.enabled = false;
    }
}
