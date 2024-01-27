using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dad : Entity
{

    public Entity Mom;

    public override void Execute()
    {
        base.Execute();


        if (Random.Range(0f, 1f) < 0.15f)
        {
            Deck.instance.AddDeck(Mom);
        }
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "BoyFriend")
            {
                GoldManager.instance.gold -= 30;
                return;
            }
        }

        GoldManager.instance.gold += 25;
    }

    
}
