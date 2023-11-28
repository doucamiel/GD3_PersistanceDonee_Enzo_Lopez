using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Quest")]
public class QuestData : ScriptableObject
{
    public Objectives[] Objectives;
    public bool IsStarted;
    public bool IsFinished;

    public void CheckQuest()
    {
        bool result = true;
        for (int i = 0; i < Objectives.Length; i++)
        {
            if (!Objectives[i].IsFinished)
            {
                result = false;
                break;
            }
        }
    }
    public void StartQuest()
    {
        IsStarted = true;
    }
    public void EndQuest()
    {
        IsFinished = true;
    }
    public void CheckObjective(int NumObject)
    {
        if (Objectives[NumObject].ActualValue == Objectives[NumObject].MaxValue)
        {
            Objectives[NumObject].IsFinished = true;
                CheckQuest();
        }
;
    }
    public void UpdateObjectives(Collectible collectible)
    {
        for (int i = 0; i < Objectives.Length; i++)
        {
            if (Objectives[i].CollectibleType == collectible.GetCollectibleType())
            {
                Objectives[i].ActualValue += collectible.GetCollectibleValue();
            }
;
        }
    }
}
