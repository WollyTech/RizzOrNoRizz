using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    [SerializeField]
    private DifficultySO currentDiff;
    public int diff;
    string easyScene = "EasyMode";
    string hardScene = "HardMode";

    public AudioSource Click1;
    public AudioSource Click2;

    public GameObject mainMenuUI;
    public GameObject dateSelectUI;
    public GameObject eCDUI;
    public GameObject hCDUI;
    public GameObject highScoreUI;

    private void Awake()
    {
        for (int i = 0; i < 5; i++)
        {
            if (currentDiff.score == 0)
            {
                currentDiff.index = i ;
                Debug.Log(currentDiff.index);
                break;
            }
            else
            {
                //currentDiff.index = i;
            }
        }
    }
    // Update is called once per frame
    private void Start()
    {
        mainMenuUI.SetActive(true);
        dateSelectUI.SetActive(false);
        eCDUI.SetActive(false);
        hCDUI.SetActive(false);
        highScoreUI.SetActive(false);
        
    }
    void Update()
    {

        
    }
    public void EasyButtonClick()
    {
        Click1.Play();
        currentDiff.difficulty = 1;
        SceneManager.LoadScene(easyScene);
    }
    public void HardButtonClick()
    {
        currentDiff.difficulty = 2;
        SceneManager.LoadScene(hardScene);
    }
    public void QuitGame()
    {
        Click2.Play();
        Application.Quit();
    }
    public void HighScoreButtonClick()
    {
        SceneManager.LoadScene("HighScore");
    }
}
