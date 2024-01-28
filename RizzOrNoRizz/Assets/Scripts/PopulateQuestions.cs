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
    const int QuestionAmount = 10;
    public void Awake()
    {
        for (int i = 0; i < QuestionAmount; i++)
        {
            AllQuestions.Add(ReturnQuestion(i));
        }
    }
    FullQuestion ReturnQuestion(int index)
    {
        FullQuestion newQuestion = new FullQuestion();
        switch (index)
        {
            case 0:
                newQuestion.Ask = new Question { whatTheyAsked = "Yo" };
                newQuestion.A = new Answer { CurrentAnswer = "Hey", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "waddup", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "ma ni***", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "f*** off", Value = 0 };
                break;
            case 1:
                newQuestion.Ask = new Question { whatTheyAsked = "Hi" };
                newQuestion.A = new Answer { CurrentAnswer = "Bye", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "Lie", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "Die", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "Cry", Value = 0 };
                break;
            case 2:
                newQuestion.Ask = new Question { whatTheyAsked = "Oli" };
                newQuestion.A = new Answer { CurrentAnswer = "W", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "O", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "L", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "E", Value = 1 };
                break;
            case 3:
                newQuestion.Ask = new Question { whatTheyAsked = "Adrian" };
                newQuestion.A = new Answer { CurrentAnswer = "A", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "D", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "R", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "N", Value = 0 };
                break;
            case 4:
                newQuestion.Ask = new Question { whatTheyAsked = "Tymek" };
                newQuestion.A = new Answer { CurrentAnswer = "T", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "M", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "E", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "K", Value = 0 };
                break;
            case 5:
                newQuestion.Ask = new Question { whatTheyAsked = "Jad" };
                newQuestion.A = new Answer { CurrentAnswer = "F", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "U", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "H", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "R", Value = 0 };
                break;
            case 6:
                newQuestion.Ask = new Question { whatTheyAsked = "Monika" };
                newQuestion.A = new Answer { CurrentAnswer = "M", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "O", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "N", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "Y", Value = 0 };
                break;
            case 7:
                newQuestion.Ask = new Question { whatTheyAsked = "Julie" };
                newQuestion.A = new Answer { CurrentAnswer = "J", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "U", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "L", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "Y", Value = 0 };
                break; 
            case 8:
                newQuestion.Ask = new Question { whatTheyAsked = "Ruslan" };
                newQuestion.A = new Answer { CurrentAnswer = "R", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "K", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "D", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = ".", Value = 0 };
                break;
            case 9:
                newQuestion.Ask = new Question { whatTheyAsked = "Alex" };
                newQuestion.A = new Answer { CurrentAnswer = "B", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "W", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "E", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "S", Value = 0 };
                break;
            case 10:
                newQuestion.Ask = new Question { whatTheyAsked = "Martin" };
                newQuestion.A = new Answer { CurrentAnswer = "M", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "R", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "T", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "N", Value = 0 };
                break;
        }
        return newQuestion;
    }

}
