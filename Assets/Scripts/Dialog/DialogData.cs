using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New DialogDatas")]
public class DialogData : ScriptableObject
{
    public SentenceData[] Sentences;
}
