using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Theraphist : Entity
{
    public override void Execute()
    {
        base.Execute();
        int sum = 0;
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Family")
            {
                sum -= 5;
                GoldManager.instance.gold += sum;
                return;


            }

        }
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Punk")
            {
                sum += 30;
                GoldManager.instance.gold += sum;
                return;


            }

        }

        // SKIP HAKKI EKLENECEK




        sum += 5;
        GoldManager.instance.gold += sum;
        return;
    }
}