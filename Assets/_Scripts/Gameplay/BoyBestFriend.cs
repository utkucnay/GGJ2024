using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyBestFriend : Entity
{
    public Entity GirlFriend;
    public Entity BoyFriend;
    public Entity Internet;

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
                        return;
                    }
                }

            }
        }

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Internet")
            {
                GoldManager.instance.gold += 30;
            }
        }

        if (Random.Range(0f, 1f) < 0.05f)
        {
            GoldManager.instance.gold -= 5;
            return;
        }
        else
        {
            GoldManager.instance.gold += 15;
            return;
        }

    }
}


