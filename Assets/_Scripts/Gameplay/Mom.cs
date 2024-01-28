using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mom : Entity
{
    public Entity Family;
    public override void Execute()
    {
        base.Execute();
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Dad")
            {
                for (int j = 0; j < entitiesInArea.Length; j++)
                {
                    if (entitiesInArea[j].GetType().Name == "Baby")
                    {
                        Deck.instance.AddDeck(Family);
                        Deck.instance.RemoveDeck(this);
                        Deck.instance.RemoveDeck(entitiesInArea[i]);
                        Deck.instance.RemoveDeck(entitiesInArea[j]);
                        return;
                    }
                }

            }
        }
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "GirlFriend")
            {
                GoldManager.instance.gold -= 30;
                
            }
        }
        if (Random.Range(0f, 1f) < 0.25f)
        {
            GoldManager.instance.gold += 25;
            return;
        }
        else
        {

            GoldManager.instance.gold -=40;
            return;
        }

        



    }
}
