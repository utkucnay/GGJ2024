using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public struct LevelData 
{
    public TurnData[] turnDatas;
    public int turnCount { get { return turnDatas.Length; } }
    public int regGold;
}

[System.Serializable]
public struct TurnData 
{
    public int cardShowCount;
}

public class TurnManager : Singleton<TurnManager>
{
    public LevelData[] levelDatas;

    [HideInInspector]
    public UnityAction onStartTurnEvent;
    [HideInInspector]
    public UnityAction onNextTurnEvent;
    [HideInInspector]
    public UnityAction onEndTurnEvent;

    [HideInInspector]
    public UnityAction onShowCardEvent;
    [HideInInspector]
    public UnityAction onSelectCardEvent;

    int currentLevel;
    int currentTurn;

    public override void Awake()
    {
        base.Awake();

        onStartTurnEvent = () =>
        {
            PickerManager.instance.StartTurn();
        };

        onNextTurnEvent = () =>
        {
            foreach (Transform child in GameCanvas.instance.temp.transform) 
            {
                Destroy(child.gameObject);
            }

            currentTurn++;
            if (levelDatas[currentLevel].turnCount >= currentTurn)
            {
                onStartTurnEvent();
            }
            else 
            {
                onEndTurnEvent();
            }
        };

        onEndTurnEvent = () =>
        {
            foreach (Transform child in GameCanvas.instance.temp.transform)
            {
                Destroy(child.gameObject);
            }
        };

        onShowCardEvent = () =>
        {
            CardManager.instance.SetCanvasActive(true);
        };

        onSelectCardEvent = () =>
        {
            CardManager.instance.SetCanvasActive(false);
            onNextTurnEvent();
        };
    }

    public IEnumerator Start()
    {
        yield return new WaitForSeconds(.5f);
        onStartTurnEvent();
    }
}
