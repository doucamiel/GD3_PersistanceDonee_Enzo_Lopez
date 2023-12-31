using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private ScoreDatas _ScoreData;
    [SerializeField] private Objectives[] _Objectives;
    
    private void Start()
    {
        for (int i = 0; i < _Objectives.Length; i++)
        {
            _Objectives[i].InitObjectiveValue();
            _Objectives[i].IsFinished = false;

        }
        _ScoreData.InitScoreValue(0);
        SceneManager.LoadScene(0);
        
    }
}
