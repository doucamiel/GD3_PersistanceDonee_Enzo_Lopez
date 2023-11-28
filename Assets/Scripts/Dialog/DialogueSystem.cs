using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] private DialogData _DialogDatas;
    [SerializeField] private UiDialogLong _UIDialog;
    [SerializeField] private UIDialogueAnswers _UIDialogAnswer;

    public void StartTalking(int DialogueSentenceNumber)
    {
        _UIDialog.ShowLongDialog(_DialogDatas.Sentences[DialogueSentenceNumber].LongSentence);
        string[] answers = new string[2];
        if (_DialogDatas.Sentences[DialogueSentenceNumber].Answer1 != -1)
        {
            answers[0] = _DialogDatas.Sentences[_DialogDatas.Sentences[DialogueSentenceNumber].Answer1].ShortSentence;
        } else
        {
            answers[0] = "";
        }
        if (_DialogDatas.Sentences[DialogueSentenceNumber].Answer2 != -1)
        {
            answers[0] = _DialogDatas.Sentences[_DialogDatas.Sentences[DialogueSentenceNumber].Answer2].ShortSentence;
        } else
        {
            answers[0] = "";
        }

        _UIDialogAnswer.ShowAnswers(answers);
        
    }
}
