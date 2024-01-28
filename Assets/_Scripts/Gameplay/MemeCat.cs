using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MemeCat : Entity
{

    public Entity Priest;
    public Entity Internet;
    public Entity BoyFriend;
    public Entity BoyBestFriend;
    public Entity GirlFriend;
    public Entity GirlBestFriend;
    public Entity Mom;
    public Entity Dad;

    public override void Execute()
    {
        base.Execute();

        int sum = 0;

        Deck.instance.entities.Any(x => x.GetType().Name == "Internet");
        
        if (!Deck.instance.entities.Any(x => x.GetType().Name == "Internet"))
        {
            return;
        }

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Priest")
            {
                sum -= 100;
                GoldManager.instance.gold += sum;
                return;
            }
        }

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "Internet")
            {
                sum += 350;
                GoldManager.instance.gold += sum;
                return;

            }
        }

        for (int i = 0; i < entitiesInArea.Length; i++)
        {
            if (entitiesInArea[i].GetType().Name == "BoyFriend" || entitiesInArea[i].GetType().Name == "GirlFriend" || entitiesInArea[i].GetType().Name == "BoyBestFriend" || entitiesInArea[i].GetType().Name == "GirlBestFriend" || entitiesInArea[i].GetType().Name == "Mom" || entitiesInArea[i].GetType().Name == "Dad" || entitiesInArea[i].GetType().Name == "Wife" || entitiesInArea[i].GetType().Name == "Husband")
            {
                sum += 300;
                GoldManager.instance.gold += sum;
                return;

            }
        }

            sum += 250;
            GoldManager.instance.gold += sum;
            return;
    }
}