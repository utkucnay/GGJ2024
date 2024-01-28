using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clown : Entity
{
    public Entity Festival;

    public override void Execute()
    {
        base.Execute();
        int sum = 0;
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Festival")
            {
                sum += 400;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }
        }

        if (Random.Range(0f, 1f) < 0.15f)
        {
            sum -= 25;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
        else
        {
            sum += 25;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }

    }
}