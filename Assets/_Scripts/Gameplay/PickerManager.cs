using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Sprites;
using UnityEngine;

public class PickerManager : Singleton<PickerManager>
{
    public void StartTurn()
    {
        var seq = DOTween.Sequence();

        var pickerAreas = GetComponentsInChildren<PickerArea>();

        List<Entity> entitiesShuffle = new List<Entity>(Deck.instance.entities);
        List<Entity> entities = new();
        List<Picker> pickerss = new();

        entitiesShuffle =  entitiesShuffle.OrderBy(x => Random.Range(0f, 1f)).ToList();
        int countDeck = Deck.instance.entities.Count;

        int index = 0;

        foreach (var pickerArea in pickerAreas)
        {
            var pickers = pickerArea.GetPickers();

            foreach (var picker in pickers)
            {
                if(index < countDeck)
                {
                    var card = Instantiate(entitiesShuffle[index], Deck.instance.transform.position, Quaternion.identity, GameCanvas.instance.temp.transform);
                    entities.Add(card);
                }

                pickerss.Add(picker);
                index++;
            }
        }

        List<Picker> pickerShuffle;
        pickerShuffle = pickerss.OrderBy(x => Random.Range(0f, 1f)).Take(countDeck).ToList();
        pickerShuffle = pickerShuffle.OrderBy((x) =>
        {
            return pickerss.IndexOf(x);
        }).ToList();

        for(int i = 0; i < entities.Count; i++) 
        {
            seq.Append(entities[i].Pick(pickerShuffle[i].transform.position, .55f));
        }

        for (int i = 0; i < entities.Count; i++)
        {
            seq.AppendCallback(entities[i].Execute);
            seq.AppendInterval(.55f);
        }

        seq.AppendCallback(() => 
        {
            TurnManager.instance.onShowCardEvent();
        });
    }
}
