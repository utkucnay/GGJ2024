using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor.Sprites;
using UnityEngine;

public class Entity : MonoBehaviour //its going to abstact class
{
    public GameObject prefab;

    public Entity[] entitiesInArea;

    Picker picker;

    public virtual void Execute() 
    {
        var seq = DOTween.Sequence();
        seq.Append(transform.DOMoveY(20, .3f).SetRelative()).SetEase(Ease.InBack);
        seq.Append(transform.DOMoveY(-20, .3f).SetRelative()).SetEase(Ease.OutBack);
    }

    public void SpawnText(int num) 
    {
        var go = new GameObject();
        go.transform.SetParent(transform);
        go.transform.position = transform.position;
        go.transform.localScale = Vector3.one * .1f;
        var textMesh = go.AddComponent<TextMeshProUGUI>();
        textMesh.alignment = TextAlignmentOptions.Center;
        textMesh.text = num.ToString();
        textMesh.color = num > 0 ? Color.green : Color.red;
        go.transform.DOMoveY(100, .2f).SetRelative();
        go.transform.DOScale(.3f, .2f);
        Destroy(go, .44f);
    }

    public Tween Pick(Picker picker, float time) 
    {

        picker.card = this;
        this.picker = picker;

        Vector3 newPos = picker.transform.position;
        newPos.y += transform.gameObject.GetComponent<RectTransform>().rect.height / 2 * 8;
        newPos.x -= transform.gameObject.GetComponent<RectTransform>().rect.width / 2 * 0.5f;
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
