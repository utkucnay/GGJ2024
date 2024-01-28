using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camper : Entity
{
    public override void Execute()
    {
        base.Execute();
        int sum = 0;
        if (Random.Range(0f, 1f) < 0.15f)
        {
            sum -= 20;
            GoldManager.instance.gold += sum;
            return;
        }
        if (Random.Range(0f, 1f) < 0.35f)
        {
            sum += 40;
            GoldManager.instance.gold += sum;
            return;
        }
        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Family")
            {
                sum += 60;
                GoldManager.instance.gold += sum;
                return;
            }
        }
        sum += 10;
        GoldManager.instance.gold += sum;
        return;

    }
}