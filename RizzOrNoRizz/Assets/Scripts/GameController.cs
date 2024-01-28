using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
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

    public GameObject mainMenuUI;
    public GameObject dateSelectUI;
    public GameObject eCDUI;
    public GameObject hCDUI;
    public GameObject highScoreUI;

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
        Application.Quit();
    }
}
