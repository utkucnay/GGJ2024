using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardPool : MonoBehaviour
{
    public Card[] cards;

    public List<Card> GetRandomsCard() 
    {
        List<Card> cardShuffle = new List<Card>(cards);
        cardShuffle.OrderBy(x => Random.Range(0, cards.Length));
        return cardShuffle.Take(Mathf.Clamp(cards.Length, 0, 3)).ToList();
    }
}
