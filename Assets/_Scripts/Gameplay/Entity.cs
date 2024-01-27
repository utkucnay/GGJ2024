using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour //its going to abstact class
{
    public GameObject prefab;

    public virtual void Execute() 
    {
        Debug.Log("Execute Entity Speel");
    }
    public Tween Pick(in Vector3 pos, float time) 
    {
        Vector3 newPos = pos;
        newPos.y += transform.lossyScale.y / 2 * 10;
        return transform.DOMove(newPos, time).SetEase(Ease.OutBounce);
    }
}
