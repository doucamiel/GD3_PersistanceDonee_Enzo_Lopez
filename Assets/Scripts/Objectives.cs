using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objecties")]

public class Objectives : ScriptableObject
{
    [SerializeField] string Name;
    public int MaxValue;
    public int StartValue;
    public int ActualValue;
    public bool IsFinished;
    public string CollectibleType;

}
