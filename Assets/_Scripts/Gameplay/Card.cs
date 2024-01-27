using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Entity entity;

    public float rarity;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(AddDeck);
    }

    public void AddDeck() 
    {
        if(entity != null)
        {
            Deck.instance.AddDeck(entity);
        }
        TurnManager.instance.onSelectCardEvent();
    }
}