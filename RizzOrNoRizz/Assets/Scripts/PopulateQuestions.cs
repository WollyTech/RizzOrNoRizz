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
        AllQuestions.Clear();

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
                newQuestion.Ask = new Question { whatTheyAsked = "Why don't skeletons fight each other?" };
                newQuestion.A = new Answer { CurrentAnswer = "Because they lack the guts!", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "Because they lack the muscle!", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "Because they're too bony!", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "Because they're just too brittle.", Value = 200 };
                break;
            case 1:
                newQuestion.Ask = new Question { whatTheyAsked = "Why did the tomato turn red?" };
                newQuestion.A = new Answer { CurrentAnswer = "Because it saw the salad dressing!", Value = 50 };
                newQuestion.B = new Answer { CurrentAnswer = "Because it was embarrassed!", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "Because it was too ripe!", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "Because it was sun-kissed.", Value = 200 };
                break;
            case 2:
                newQuestion.Ask = new Question { whatTheyAsked = "Why don't scientists trust atoms?" };
                newQuestion.A = new Answer { CurrentAnswer = "Because they make up everything!", Value = 10 };
                newQuestion.B = new Answer { CurrentAnswer = "Because they're too small to see!", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "Because they're always splitting!", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "Because they're too unstable.", Value = 200 };
                break;
            case 3:
                newQuestion.Ask = new Question { whatTheyAsked = "Why was the math book sad?" };
                newQuestion.A = new Answer { CurrentAnswer = "Because it had too many problems!", Value = 250 };
                newQuestion.B = new Answer { CurrentAnswer = "Because it couldn't solve its own equations!", Value = 500 };
                newQuestion.C = new Answer { CurrentAnswer = "Because it was full of negative numbers!", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "Because it missed their X.", Value = 200 };
                break;
            case 4:
                newQuestion.Ask = new Question { whatTheyAsked = "Why did the chicken cross the road?" };
                newQuestion.A = new Answer { CurrentAnswer = "Because it wanted to get to the other side!", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "Because it heard there was free food!", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "Because it was following its friends!", Value = 150 };
                newQuestion.D = new Answer { CurrentAnswer = "Because it wanted to explore new territories.", Value = 200 };
                break;
            case 5:
                newQuestion.Ask = new Question { whatTheyAsked = "Why did the scarecrow win an award?\r\n" };
                newQuestion.A = new Answer { CurrentAnswer = "Because it was outstanding in its field!", Value = 100 };
                newQuestion.B = new Answer { CurrentAnswer = "Because it kept the birds away!", Value = 500 };
                newQuestion.C = new Answer { CurrentAnswer = "Because it had the best hat!", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "Because it was stuffed with personality.", Value = 200 };
                break;
            case 6:
                newQuestion.Ask = new Question { whatTheyAsked = "Why don't oysters donate to charity?\r\n" };
                newQuestion.A = new Answer { CurrentAnswer = "Because they're shellfish!", Value = 100 };
                newQuestion.B = new Answer { CurrentAnswer = "Because they're too busy hiding!", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "Because they don't have pockets!", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "Because they're too busy clamming up.", Value = 500 };
                break;
            case 7:
                newQuestion.Ask = new Question { whatTheyAsked = "Why did the golfer bring two pairs of pants?" };
                newQuestion.A = new Answer { CurrentAnswer = "Because he might get a hole in one!", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "Because he wanted to be prepared for any weather!", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "Because he needed a spare in case he ripped one!", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "Because he wanted to impress with his fashion sense.", Value = 200 };
                break; 
            case 8:
                newQuestion.Ask = new Question { whatTheyAsked = "Why did the chicken cross the road?" };
                newQuestion.A = new Answer { CurrentAnswer = "Because it wanted to reach the other side!", Value = 500 };
                newQuestion.B = new Answer { CurrentAnswer = "Because it saw the sploinky blingus on the other side!", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "Because it wanted to explore new territories!", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "Because it heard there were tasty bugs on the other side.", Value = 200 };
                break;
            case 9:
                newQuestion.Ask = new Question { whatTheyAsked = "Why did the banana go to the doctor?" };
                newQuestion.A = new Answer { CurrentAnswer = "Because it wasn't peeling well!", Value = 250 };
                newQuestion.B = new Answer { CurrentAnswer = "Because it slipped and fell!", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "Because it wanted to get checked for bruises!", Value = 500 };
                newQuestion.D = new Answer { CurrentAnswer = "Because it heard Adam Sandler was the doctor.", Value = 200 };
                break;
            case 10:
                newQuestion.Ask = new Question { whatTheyAsked = "Why did the skeleton go to the party?\r\n" };
                newQuestion.A = new Answer { CurrentAnswer = "Because it wanted to dance!\r\n", Value = 150 };
                newQuestion.B = new Answer { CurrentAnswer = "Because it wanted to socialize!\r\n", Value = 300 };
                newQuestion.C = new Answer { CurrentAnswer = "Because it heard Adam Sandler was performing!", Value = 100 };
                newQuestion.D = new Answer { CurrentAnswer = "Because it had a bone to pick with the DJ.", Value = 6969 };
                break;
        }
        return newQuestion;
    }
    public void resetList()
    {
        AllQuestions.Clear();

        for (int i = 0; i < QuestionAmount; i++)
        {
            AllQuestions.Add(ReturnQuestion(i));
        }
    }
}
