using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : Singleton<Deck>
{
    public List<Card> cards;

    public override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        
    }
}
