using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Objective")]

public class Objectives : ScriptableObject
{
    [SerializeField] string Name;
    public int MaxValue;
    public int StartValue;
    public int ActualValue;
    public string CollectibleType;
    public bool IsFinished;

    public void InitObjectiveValue()
    {
        ActualValue = StartValue;
    }

   
}
