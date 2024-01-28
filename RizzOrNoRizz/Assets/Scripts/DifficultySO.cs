using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu]
public class DifficultySO : ScriptableObject
{
    [SerializeField]
    private int _difficulty = 1;
    [SerializeField]
    private List<int> _score;
    [SerializeField]
    private int _index = 0;
    // Start is called before the first frame update
    public int difficulty
    {
        get { return _difficulty; }
        set { _difficulty = value; }
    }
    public int score
    { 
        get { return _score[index]; }
        set { _score[index] = value; } 
    }
    public int index
    {
        get { return _index; }
        set { _index = value; }
    }

}


