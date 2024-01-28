using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mom : Entity
{
    public Entity Family;
    public override void Execute()
    {
        base.Execute();
        int sum = 0;
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
                sum -= 30;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }
        }
        if (Random.Range(0f, 1f) < 0.25f)
        {
            sum += 25;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
        else
        {

            sum -=40;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }

        



    }
}
