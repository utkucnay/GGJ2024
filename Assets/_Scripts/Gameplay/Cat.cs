using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Entity
{
    public Entity MemeCat;
    public override void Execute()
    {
        base.Execute();
        int sum = 0;
        for (int i = 0; i < entitiesInArea.Length; i++)
        {

            if (entitiesInArea[i].GetType().Name == "Internet")
            {
                Deck.instance.AddDeck(MemeCat);
                Deck.instance.RemoveDeck(this);
                Deck.instance.RemoveDeck(entitiesInArea[i]);
                return;

            }
        }



        for (int i = 0; i < entitiesInArea.Length; i++)
        {

            if (entitiesInArea[i].GetType().Name == "Dog")
            {
                return;
            }
        }

        if (Random.Range(0f, 1f) < 0.08f)
        {
            sum  -= 20;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;

        }
        else
        {
            sum += 20;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
    }

}
