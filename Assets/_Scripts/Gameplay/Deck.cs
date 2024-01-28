using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : Singleton<Deck>
{
    public List<Entity> entities;
    Animator animator;

    public override void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        
    }

    public void AddDeck(Entity entity) 
    {
        entities.Add(entity);
    }
    public void RemoveDeck(Entity entity)
    {
        entities.RemoveAt(entities.FindIndex(x => x.GetType() == entity.GetType()));
    }

    public void Draw()
    {
        animator.SetTrigger("Draw");
    }
}
