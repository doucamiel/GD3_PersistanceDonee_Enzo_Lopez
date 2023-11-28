using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJCrontroller : MonoBehaviour, ITalk
{
    private DialogueSystem _dialogSystem;
    [SerializeField] private int _startSentence;
    [SerializeField] private int _intermediatetSentence;
    [SerializeField] private int _endSentence;
    [SerializeField] private QuestData _questData;

    //[SerializeField] private DialogData _DialogDatas;

    private void Start()
    {
        _dialogSystem = GetComponent<DialogueSystem>();
    }


    public void Talk()
    {
        if (_questData.IsStarted)
        {
            if (_questData.IsFinished)
            {
                _dialogSystem.StartTalking(_endSentence);
            } else
            {
                _dialogSystem.StartTalking(_intermediatetSentence);
            }
        } else
        {
            _dialogSystem.StartTalking(_startSentence);
        }
        //throw new System.NotImplementedException();
       
    }
}
