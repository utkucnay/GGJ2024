using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disco : Entity
{
    public override void Execute()
    {
        base.Execute();
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Priest")
            {
                GoldManager.instance.gold -= 40;
                return;
            }
        }
        if (Random.Range(0f, 1f) < 0.20f)
        {
            GoldManager.instance.gold -= 40;
        }
        else
        {
            for (int i = 0; i < entitiesInArea.Length; i++)
            {
                if (entitiesInArea[i].GetType().Name == "Barista")
                {
                    GoldManager.instance.gold += 80;
                    return;
                }
            }
            for (int i = 0; i < entitiesInArea.Length; i++)
            {
                if (entitiesInArea[i].GetType().Name == "Festival")
                {
                    GoldManager.instance.gold += 120;
                    return;
                }

            }
            GoldManager.instance.gold += 40;
            return;
        }
    }   
}