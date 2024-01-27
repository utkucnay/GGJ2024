using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Entity entity;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(AddDeck);
    }

    public void AddDeck() 
    {
        Deck.instance.AddDeck(entity);
        TurnManager.instance.onSelectCardEvent();
    }
}