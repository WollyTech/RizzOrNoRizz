using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private DifficultySO currentDiff;
    public TMP_Text DifficultyText;
    // Start is called before the first frame update
    void Start()
    {
        if ( currentDiff.difficulty == 1)
        {
            DifficultyText.text = "Easy";
        }
        if (currentDiff.difficulty == 2)
        {
            DifficultyText.text = "Hard";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
