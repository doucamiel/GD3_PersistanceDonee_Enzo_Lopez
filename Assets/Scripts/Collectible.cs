using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour,ICollectible
{
    [SerializeField] int _value;
    [SerializeField] ScoreDatas _scoreData;
    [SerializeField] string _collectibleType;


    public void Collect()
    {
        _scoreData.UpdateScoreValue(_value);
        Destroy(gameObject);
    }

    public string GetCollectibleType()
    {
        return _collectibleType;
    }

    public int GetCollectibleValue()
    {
        return _value;
    }
}
