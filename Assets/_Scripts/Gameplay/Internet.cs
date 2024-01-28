using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Internet : Entity
{
    public Entity Camper;
    public Entity Mom;
    public Entity Dad;

    public override void Execute()
    {
        base.Execute();

        int sum = 0;

        if (entitiesInArea.Length == 0)
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
                if (entitiesInArea[i].GetType().Name == "Camper")
                {
                    sum -= 50;
                    GoldManager.instance.gold += sum;
                    SpawnText(sum);
                    return;
                }
            }

            for (int i = 0; i < entitiesInArea.Length; i++)
            {
                if (entitiesInArea[i].GetType().Name == "Mom" || entitiesInArea[i].GetType().Name == "Dad")
                {
                    sum += 60;
                    GoldManager.instance.gold += sum;
                    SpawnText(sum);
                    return;

                }
            }

            sum += 50;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;

        }
    }

}


