using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Internet : Entity
{
    public Entity Camper;
    public Entity Mom;
    public Entity Dad;

    public override void Execute()
    {
        base.Execute();

        if (entitiesInArea.Length == 0)
        {
            GoldManager.instance.gold -= 100;
            return;
        }

        else
        {
            for (int i = 0; i < entitiesInArea.Length; i++)
            {
                if (entitiesInArea[i].GetType().Name == "Camper")
                {
                    GoldManager.instance.gold -= 50;
                    return;
                }
            }

            for (int i = 0; i < entitiesInArea.Length; i++)
            {
                if (entitiesInArea[i].GetType().Name == "Mom" || entitiesInArea[i].GetType().Name == "Dad")
                {
                    GoldManager.instance.gold += 60;
                    return;

                }
            }

            GoldManager.instance.gold += 50;
            return;

        }
    }

}


