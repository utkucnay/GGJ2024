using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : Singleton<Deck>
{
    public List<Entity> entities;

    public override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        
    }

    public void AddDeck(Entity entity) 
    {
        entities.Add(entity);
    }
}
