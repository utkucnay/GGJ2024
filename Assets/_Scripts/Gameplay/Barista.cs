using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barista : Entity
{
    public override void Execute()
    {
        base.Execute();

        int sum = 0;

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Dad" || entitiesInArea[i].GetType().Name == "Mom")
            {
                return;
            }
        }

        if (Random.Range(0f, 1f) < 0.05f)
        {
            sum -= 70;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
        else
        {
            for (int i = 0; i < entitiesInArea.Length; i++)
            {
                if (entitiesInArea[i].GetType().Name == "Festival")
                {
                    sum += 60;
                    GoldManager.instance.gold += sum;
                    SpawnText(sum);
                    return;
                }
            }

            for (int i = 0; i < entitiesInArea.Length; i++)
            {
                if (entitiesInArea[i].GetType().Name == "Disco")
                {
                    sum += 30;
                    GoldManager.instance.gold += sum;
                    SpawnText(sum);
                    return;
                }
            }

            sum += 20;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
    }
}