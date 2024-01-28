using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingController : MonoBehaviour
{
    public TMP_Text score;
    [SerializeField]
    private DifficultySO newScore;
    // Start is called before the first frame update
    void Start()
    {
        score.text = newScore.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
