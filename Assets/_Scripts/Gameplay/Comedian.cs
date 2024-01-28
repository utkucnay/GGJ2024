using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comedian : Entity
{
    public override void Execute()
    {
        base.Execute();
        int sum = 0;

        if (Random.Range(0f, 1f) < 0.05f)
        {
            sum -= 45;
            GoldManager.instance.gold += sum;

            if (Random.Range(0f, 1f) < 0.05f)
            {
                sum -= 45;
                GoldManager.instance.gold += sum;

                if (Random.Range(0f, 1f) < 0.05f)
                {
                    sum -= 45;
                    GoldManager.instance.gold += sum;
                    return;
                }

                return;
            }
            return;
        }

        else
        {
            sum += 45;
            GoldManager.instance.gold += sum;

            if (Random.Range(0f, 1f) < 0.05f)
            {
                sum += 45;
                GoldManager.instance.gold += sum;

                if (Random.Range(0f, 1f) < 0.05f)
                {
                    sum += 45;
                    GoldManager.instance.gold += sum;
                    return;
                }
                return;
            }
            return;
        }

    }
}


