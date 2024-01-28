using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlFriend : Entity
{
    public Entity Wife;
    public override void Execute()
    {
        base.Execute();
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "GirlFriend")
            {
                for (int j = 0; j < entitiesInArea.Length; j++)
                {
                    if (entitiesInArea[j].GetType().Name == "BoyFriend")
                    {

                        Deck.instance.RemoveDeck(this);
                        Deck.instance.RemoveDeck(entitiesInArea[i]);
                        Deck.instance.RemoveDeck(entitiesInArea[j]);

                    }
                }

            }
        }
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Baby")
            {
                Deck.instance.AddDeck(Wife);
                Deck.instance.RemoveDeck(this);
                Deck.instance.RemoveDeck(entitiesInArea[i]);
            }
        }
        if (Random.Range(0f, 1f) < 0.05f)
        {
            GoldManager.instance.gold -= 100;
            return;
        }
        else
        {
            GoldManager.instance.gold += 50;
            return;
        }

    }
}
