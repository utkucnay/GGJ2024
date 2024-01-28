using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clown : Entity
{
    public Entity Festival;

    public override void Execute()
    {
        base.Execute();
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Festival")
            {
                GoldManager.instance.gold += 2000;
                return;
            }
        }

        if (Random.Range(0f, 1f) < 0.15f)
        {
            GoldManager.instance.gold -= 25;
            return;
        }
        else
        {
            GoldManager.instance.gold += 25;
        }

    }
}