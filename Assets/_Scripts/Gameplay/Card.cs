using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour //its going to abstact class
{
    public GameObject prefab;

    //public abstract void Execute();
    public void Pick(in Vector3 pos) 
    {
        transform.DOMove(pos, .3f);
    }
}
