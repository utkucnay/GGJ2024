using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Swimmer : Entity
{
    public override void Execute()
    {
        base.Execute();

        int sum = 0;

        if (Random.Range(0f, 1f) < 0.10f)
        {
            sum -= 45;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return; ;
        }

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Family")
            {
                sum += 45;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }
        }

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Camp")
            {
                sum += 30;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }
        }

        sum += 15;
        GoldManager.instance.gold += sum;
        SpawnText(sum);
        return;
    }
}