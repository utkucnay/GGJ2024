using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cook : Entity
{
    public Entity Dog;
    
    public override void Execute()
    {
        base.Execute();
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Dog")
            {
                GoldManager.instance.gold -= 20;
                return;
                    
            }
        }

        if (Random.Range(0f, 1f) < 0.20f)
        {
            GoldManager.instance.gold -= 50;
            return;
        }
        else if (Random.Range(0f, 1f) < 0.05f)
        {
            GoldManager.instance.gold += 50;
            return;
        }
        else
        {
            GoldManager.instance.gold += 20;
        }
    }

}
