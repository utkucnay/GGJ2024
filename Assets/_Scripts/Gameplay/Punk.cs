using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Punk : Entity
{
    int executionnumber = 0;

    public override void Execute()
    {
        base.Execute();

        int sum = 0;

        if (Random.Range(0f, 1f) < 0.15f)
        {
            Deck.instance.RemoveDeck(this);
            return;
        }

        if (Random.Range(0f, 1f) < 0.2f)
        {
            sum -= 50;
            GoldManager.instance.gold += sum;
            return;
        }

        if (Random.Range(0f, 1f) < 0.1f)
        {
            sum += 100;
            GoldManager.instance.gold += sum;
            return;
        }

        executionnumber++;

        if (executionnumber < 4) {
            
            executionnumber = 0;
            //to do silme hakkı eklenecek
        }

        sum += 30;
        GoldManager.instance.gold += sum;
        return;
    }
}