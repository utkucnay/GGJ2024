using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

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
            var cardd = Instantiate(card, layout);
            cardd.GetComponent<Button>().interactable = false;
            this.cards.AddLast(cardd);
        }
        canvas.enabled = true;
    }

    public void RemoveDeckViewer()
    {
        foreach (var card in cards)
        {
            Destroy(card.gameObject);
        }
        cards.Clear();
        canvas.enabled = false;
    }
}
