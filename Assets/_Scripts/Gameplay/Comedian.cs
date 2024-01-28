using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comedian : Entity
{
    public override void Execute()
    {
        base.Execute();

        if (Random.Range(0f, 1f) < 0.05f)
        {
            GoldManager.instance.gold -= 45;

            if (Random.Range(0f, 1f) < 0.05f)
            {
                GoldManager.instance.gold -= 45;

                if (Random.Range(0f, 1f) < 0.05f)
                {
                    GoldManager.instance.gold -= 45;
                    return;
                }

                return;
            }
            return;
        }

        else
        {
            GoldManager.instance.gold += 45;

            if (Random.Range(0f, 1f) < 0.05f)
            {
                GoldManager.instance.gold += 45;

                if (Random.Range(0f, 1f) < 0.05f)
                {
                    GoldManager.instance.gold += 45;
                    return;
                }
                return;
            }
            return;
        }

    }
}


