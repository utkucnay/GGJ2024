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
        cardShuffle = cardShuffle.Where(x => x.isPool).OrderBy(x => Random.Range(0f, 1f) / x.rarity)
        .Take(Mathf.Clamp(cards.Length, 0, 3)).ToList();
        return cardShuffle;
    }
}
