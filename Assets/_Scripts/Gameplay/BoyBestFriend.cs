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
        int sum = 0;

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
                sum += 30;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }
        }

        if (Random.Range(0f, 1f) < 0.05f)
        {
            sum -= 5;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
        else
        {
            sum += 15;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }

    }
}


