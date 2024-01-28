using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Dog : Entity
{
    public override void Execute()
    {
        base.Execute();
        for (int i = 0; i < entitiesInArea.Length; i++)
        {

            if (entitiesInArea[i].GetType().Name == "Cat")
            {
                return;
            }
        }
        for (int i = 0; i < entitiesInArea.Length; i++)
        {

            if (entitiesInArea[i].GetType().Name == "Camper")
            {
                GoldManager.instance.gold += 80;
                return;
            }
        }
        if (Random.Range(0f, 1f) < 0.15f)
        {
            GoldManager.instance.gold -= 30;
            return;
        }
        else
        {
            GoldManager.instance.gold += 20;
            return;
        }






    }
}
