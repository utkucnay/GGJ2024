using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Festival : Entity
{
    public override void Execute()
    {
        base.Execute();

        int sum = 0;

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Baby")
            {
                sum -= 100;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }
        }
        if (Random.Range(0f, 1f) < 0.10f)
        {
            sum -= 100;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
        else
        {
            for (int i = 0; i < entitiesInArea.Length; i++)
            {
                if (entitiesInArea[i].GetType().Name == "BoyBestFriend" || entitiesInArea[i].GetType().Name == "GirlBestFriend")
                {
                    sum += 500;
                    GoldManager.instance.gold += sum;
                    SpawnText(sum);
                    return;
                }
            }
            
            for (int i = 0; i < entitiesInArea.Length; i++)
            {
                if (entitiesInArea[i].GetType().Name == "BoyFriend" || entitiesInArea[i].GetType().Name == "GirlFriend")
                {
                    sum += 400;
                    GoldManager.instance.gold += sum;
                    SpawnText(sum);
                    return;
                }
            }

            for (int i = 0; i < entitiesInArea.Length; i++)
            {
                if (entitiesInArea[i].GetType().Name == "Camper")
                {
                    sum += 450;
                    GoldManager.instance.gold += sum;
                    SpawnText(sum);
                    return;
                }

            }

            if (Random.Range(0f, 1f) < 0.05f)
            {
                sum += 500;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }

            sum += 300;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
    }
}