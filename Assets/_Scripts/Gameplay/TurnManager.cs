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

    [HideInInspector]
    public UnityAction onWinGame;

    int currentLevel;
    int currentTurn;
    int showedCards = 0;

    public bool IsFinishTurn { get => currentTurn >= levelDatas[currentLevel].turnCount;  }

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
            
            if (!IsFinishTurn)
            {
                onStartTurnEvent();
            }
            else 
            {
                onEndTurnEvent();
            }

            currentTurn++;
        };

        onEndTurnEvent = () =>
        {
            foreach (Transform child in GameCanvas.instance.temp.transform)
            {
                Destroy(child.gameObject);
            }

            int reqGold = levelDatas[currentLevel].regGold;
            if (GoldManager.instance.gold >= reqGold)
            {
                GoldManager.instance.gold -= reqGold;
            }
            else
            {
                //Lose Game
                Debug.Log("Lose Game!");
                return;
            }

            currentLevel++;
            currentTurn = 0;

            if (currentLevel >= levelDatas.Length)
            {
                //Win Game
                Debug.Log("Win Game!");
                return;
            }

            onShowCardEvent();
        };

        onShowCardEvent = () =>
        {
            if (IsFinishTurn) 
            {
                onEndTurnEvent();
                return;
            }
            CardManager.instance.SetCanvasActive(true);
        };

        onSelectCardEvent = () =>
        {
            CardManager.instance.SetCanvasActive(false);
            showedCards++;

            if (showedCards < levelDatas[currentLevel].turnDatas[currentTurn].cardShowCount) 
            {
                onShowCardEvent();
            }
            else 
            {
                showedCards = 0;
                onNextTurnEvent();
            }
        };
    }

    public IEnumerator Start()
    {
        yield return new WaitForSeconds(.5f);
        onShowCardEvent();
        yield break;
    }
}
