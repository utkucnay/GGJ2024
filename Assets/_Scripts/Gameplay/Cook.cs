using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cook : Entity
{
    public Entity Dog;
    
    public override void Execute()
    {
        base.Execute();

        int sum = 0;

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Dog")
            {
                sum -= 20;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
                    
            }
        }

        if (Random.Range(0f, 1f) < 0.20f)
        {
            sum -= 50;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
        else if (Random.Range(0f, 1f) < 0.05f)
        {
            sum += 50;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
        else
        {
            sum += 20;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }
    }

}
