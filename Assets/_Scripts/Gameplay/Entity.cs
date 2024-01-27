using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Sprites;
using UnityEngine;

public class Entity : MonoBehaviour //its going to abstact class
{
    public GameObject prefab;

    public Entity[] entitiesInArea;

    Picker picker;

    public virtual void Execute() 
    {
        Debug.Log("Execute Entity Speel");
    }
    public Tween Pick(Picker picker, float time) 
    {

        picker.card = this;
        this.picker = picker;

        Vector3 newPos = picker.transform.position;
        newPos.y += transform.gameObject.GetComponent<RectTransform>().rect.height / 2 * 6;
        return transform.DOMove(newPos, time).SetEase(Ease.OutBounce);
    }

    public void SetPickerArea() 
    {
        entitiesInArea = picker.GetComponentInParent<PickerArea>().GetPickers()
            .Select(x => x.card)
            .Where(x => x != null)
            .Where (x => x != this)
            .ToArray();
    }
}
