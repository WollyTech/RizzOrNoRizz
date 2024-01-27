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
    string sceneToLoad = "SampleScene";

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void EasyButtonClick()
    {
        currentDiff.difficulty = 1;
        SceneManager.LoadScene(sceneToLoad);
    }
    public void HardButtonClick()
    {
        currentDiff.difficulty = 2;
        SceneManager.LoadScene(sceneToLoad);
    }
}
