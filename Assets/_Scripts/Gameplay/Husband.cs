using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Husband : Entity
{
    public Entity BoyFriend;
    public Entity GirlFriend;
    public override void Execute()
    {
        base.Execute();

        int sum = 0;

        if (Random.Range(0f, 1f) < 0.05f)
        {
            GoldManager.instance.gold -= 1000;
            SpawnText(sum);
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
        

        GoldManager.instance.gold += 100;
        SpawnText(sum);
        return;


    }
}
