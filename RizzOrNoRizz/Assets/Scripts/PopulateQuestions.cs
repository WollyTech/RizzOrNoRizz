using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Answer
{
    public string CurrentAnswer { get; set; }
    public int Value { get; set; }
}
public struct Question
{
    public string whatTheyAsked { get; set; }

}
public struct FullQuestion
{
    public Question Ask { get; set; }
    public Answer A { get; set; }
    public Answer B { get; set; }
    public Answer C { get; set; }
    public Answer D { get; set; }

}
public class PopulateQuestions : MonoBehaviour
{
    public List<FullQuestion> AllQuestions = new List<FullQuestion>();
    const int QuestionAmount = 2;
    public void Awake()
    {
        for (int i = 0; i < QuestionAmount; i++)
        {
            AllQuestions.Add(ReturnQuestion(i));
            int a = 0;
        }
    }
    FullQuestion ReturnQuestion(int index)
    {
        FullQuestion newQuestion = new FullQuestion();
        if (index == 0)
        {
            newQuestion.Ask = new Question { whatTheyAsked = "Yo" };
            newQuestion.A = new Answer { CurrentAnswer = "Hey", Value = 1 };
            newQuestion.B = new Answer { CurrentAnswer = "Hey", Value = 1 };
            newQuestion.C = new Answer { CurrentAnswer = "Hey", Value = 1 };
            newQuestion.D = new Answer { CurrentAnswer = "Hey", Value = 1 };
        }
        else if (index == 1)
        {
            newQuestion.Ask = new Question { whatTheyAsked = "Hi" };
            newQuestion.A = new Answer { CurrentAnswer = "Bye", Value = 1 };
            newQuestion.B = new Answer { CurrentAnswer = "Lie", Value = 1 };
            newQuestion.C = new Answer { CurrentAnswer = "Die", Value = 1 };
            newQuestion.D = new Answer { CurrentAnswer = "Cry", Value = 1 };
        }

        


        return newQuestion;
    }

}
