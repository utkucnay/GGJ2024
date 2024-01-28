using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Dog : Entity
{
    public override void Execute()
    {
        base.Execute();

        int sum = 0;

        for (int i = 0; i < entitiesInArea.Length; i++)
        {

            if (entitiesInArea[i].GetType().Name == "Cat")
            {
                return;
            }
        }

        if (Random.Range(0f, 1f) < 0.15f)
        {
            sum -= 30;
            GoldManager.instance.gold += sum;
            SpawnText(sum);
            return;
        }

        for (int i = 0; i < entitiesInArea.Length; i++)
        {

            if (entitiesInArea[i].GetType().Name == "Camper")
            {
                sum += 80;
                GoldManager.instance.gold += sum;
                SpawnText(sum);
                return;
            }
        }

        

         sum += 20;
         GoldManager.instance.gold += sum;
         SpawnText(sum);
         return;

    }
}
