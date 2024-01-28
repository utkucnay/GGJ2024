using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Family : Entity
{

    public Entity Punk;
    public Entity Wife;
    public Entity Husband;
    public Entity Baby;

    public override void Execute()
    {
        base.Execute();

        int sum = 0;

        if (Random.Range(0f, 1f) < 0.02f)
        {
            sum -= 100;
            GoldManager.instance.gold += sum;
            return;
        }

        for (int m = 0; m < entitiesInArea.Length; m++)
        {
            if (entitiesInArea[m].GetType().Name == "Punk")
            {
               sum -= 60;
               GoldManager.instance.gold += sum;
               return;
            }
        }

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Wife" || entitiesInArea[i].GetType().Name == "Husband")
            {
                for (int j = 0; j < entitiesInArea.Length; j++)
                {
                    if (entitiesInArea[j].GetType().Name == "Wife" || entitiesInArea[j].GetType().Name == "Husband")
                    {
                        for (int m = 0; m < entitiesInArea.Length; m++)
                        {
                            if (entitiesInArea[m].GetType().Name == "Baby")
                            {
                                Deck.instance.AddDeck(this);
                                return;
                            }
                        }
                    }
                }
            }
        }
        
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Wife" || entitiesInArea[i].GetType().Name == "Husband")
            {
                sum += 600;
                GoldManager.instance.gold += sum;
                return;
            }
        }
        
        sum += 500;
        GoldManager.instance.gold += sum;
        return;

    }
}