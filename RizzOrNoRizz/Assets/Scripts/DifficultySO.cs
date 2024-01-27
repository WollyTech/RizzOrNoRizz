using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DifficultySO : ScriptableObject
{
    [SerializeField]
    private int _difficulty = 1;
    // Start is called before the first frame update
    public int difficulty
    {
        get { return _difficulty; }
        set { _difficulty = value; }
    }
}
