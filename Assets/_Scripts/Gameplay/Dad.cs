using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dad : Entity
{

    public Entity Mom;
    public Entity Family;
    public override void Execute()
    {
        base.Execute();
        int sum = 0;
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Mom")
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

        if (Random.Range(0f, 1f) < 0.15f)
        {
            Deck.instance.AddDeck(Mom);
        }
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "BoyFriend")
            {
                sum -= 30;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }
        }

        sum += 25;
        GoldManager.instance.gold += sum;
        SpawnText(sum);
        return;
    }

    
}
