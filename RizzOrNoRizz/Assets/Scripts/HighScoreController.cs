using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScoreController : MonoBehaviour
{
    [SerializeField]
    private DifficultySO addScore;
    public List<TMP_Text> scores;
    

    // Start is called before the first frame update
    void Start()
    {
        addScore.index = 0;
        for (int i = 0; i < scores.Count ; i++)
        {

                Debug.Log("Updating score for element at index " + i);
                scores[i].text = addScore.score.ToString();
                addScore.index++;
                
        }
        addScore.index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
