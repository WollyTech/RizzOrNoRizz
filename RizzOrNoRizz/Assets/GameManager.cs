using System.Collections;
    using System.Collections.Generic;
    using TMPro;
    using UnityEngine;
    using UnityEngine.Rendering;
    using UnityEngine.SceneManagement;
    using UnityEngine.SocialPlatforms.Impl;
    using UnityEngine.UI;


public class GameManager : MonoBehaviour
    {
    [SerializeField]
    private DifficultySO currentDiff;
    public TMP_Text Prompt;
    public List<FullQuestion> AllQuestions;
    public TMP_Text bA;
    public TMP_Text bB;
    public TMP_Text bC;
    public TMP_Text bD;

    public TMP_Text scoreText;
    public TMP_Text finalScoreText;
    public TMP_Text gradeText;

    public int index = 0;
    public int round = 0;

    public GameObject promptUI;
    public GameObject scoreUI;
    public GameObject finalScoreUI;

    // Start is called before the first frame update
    void Start()
    {
        AllQuestions = this.GetComponent<PopulateQuestions>().AllQuestions;
        changeText();

        round = 0;
        currentDiff.score = 0;

        promptUI.SetActive(true);
        scoreUI.SetActive(false);
        finalScoreUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (round == 5)
        {
            //set all open screens to inactive and final score to active
            promptUI.SetActive(false); scoreUI.SetActive(false);
            finalScoreUI.SetActive(true);
            finalScoreText.text = "Score = " + currentDiff.score + "RP";
            if (currentDiff.score >= 1250)
                gradeText.text = "Ugh, get away from me creep";
            if (currentDiff.score >= 1500)
                gradeText.text = "I guess I'll go out with you";
            if (currentDiff.score >= 1750)
                gradeText.text = "Rizzy";
            if (currentDiff.score >= 2000)
                gradeText.text = "Rizzlord";
            if (currentDiff.score >= 2250)
                gradeText.text = "Rizzgod";
        }
    }

    public void newRound()
    {
        round++;
        AllQuestions.RemoveAt(index);
        changeText();
    }
    void changeText()
    {
        if (round < AllQuestions.Count)
        {
            index = Random.Range(0, AllQuestions.Count);

            Prompt.text = AllQuestions[index].Ask.whatTheyAsked;
            bA.text = AllQuestions[index].A.CurrentAnswer;
            bB.text = AllQuestions[index].B.CurrentAnswer;
            bC.text = AllQuestions[index].C.CurrentAnswer;
            bD.text = AllQuestions[index].D.CurrentAnswer;

            Debug.Log(bA.text);
        }
    }

    public void ClickButtonA()
    {
        currentDiff.score += AllQuestions[index].A.Value;
        scoreText.text = "+" + AllQuestions[index].A.Value + "RP";
    }
    public void ClickButtonB()
    {
        currentDiff.score += AllQuestions[index].B.Value;
        scoreText.text = "+" + AllQuestions[index].B.Value + "RP";
    }
    public void ClickButtonC()
    {
        currentDiff.score += AllQuestions[index].C.Value;
        scoreText.text = "+" + AllQuestions[index].C.Value + "RP";
    }
    public void ClickButtonD()
    {
        currentDiff.score += AllQuestions[index].D.Value;
        scoreText.text = "+" + AllQuestions[index].D.Value + "RP";
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
