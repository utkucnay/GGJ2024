using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyFriend : Entity
{
    public Entity Husband;
    public override void Execute()
    {
        base.Execute();
        int sum = 0;
        if (Random.Range(0f, 1f) < 0.05f)
        {
            sum -= 100;
            GoldManager.instance.gold += sum;
            Deck.instance.RemoveDeck(this);
            return;
        }
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
                        return;

                    }
                }

            }
        }
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Baby")
            {
                Deck.instance.AddDeck(Husband);
                Deck.instance.RemoveDeck(this);
                Deck.instance.RemoveDeck(entitiesInArea[i]);
                return;
            }
        }
        
        sum += 50;
        GoldManager.instance.gold += sum;
        return;
        

    }
}
