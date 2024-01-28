using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Priest : Entity
{
    public override void Execute()
    {
        base.Execute();

        int sum = 0;

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Festival")
            {
                sum -= 100;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }
        }

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Punk")
            {
                sum -= 25;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }
        }

 

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Family")
            {
                sum += 100;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }
        }

        sum += 10;
        GoldManager.instance.gold += sum;
        SpawnText(sum);
        return;
    }
}