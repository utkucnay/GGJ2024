using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : Entity
{
    public Entity Priest;
    public override void Execute()
    {
        base.Execute();
        int sum = 0;
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Priest")
            {
                Deck.instance.RemoveDeck(this);
                Deck.instance.AddDeck(Priest);
                
            }

        }
        if (Random.Range(0f, 1f) < 0.80f)
        {
            sum -= 50;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Swimmer")
            {
                sum += 40;
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