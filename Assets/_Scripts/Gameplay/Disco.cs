using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Disco : Entity
{
    public override void Execute()
    {
        base.Execute();

        int sum = 0;

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Priest")
            {
                sum -= 40;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }
        }
        if (Random.Range(0f, 1f) < 0.20f)
        {
            sum -= 40;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
        }
        else
        {
            for (int i = 0; i < entitiesInArea.Length; i++)
            {
                if (entitiesInArea[i].GetType().Name == "Festival")
                {
                    sum += 120;
                    GoldManager.instance.gold += sum;
                    SpawnText(sum);
                    return;
                }

            }


            for (int i = 0; i < entitiesInArea.Length; i++)
            {
                if (entitiesInArea[i].GetType().Name == "Barista")
                {
                    sum += 80;
                    GoldManager.instance.gold += sum;
                    SpawnText(sum);
                    return;
                }
            }
            

            sum += 40;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
    }   
}