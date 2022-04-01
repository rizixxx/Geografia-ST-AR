using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript2 : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager2 quizManager;
    static double points = 0;

    
    public void Answer()
    {
        if (isCorrect)
        {
            points += 10;
            quizManager.correct();
        }
        else
        {
            points -= 2;
            quizManager.correct();
        }
    }

    public double getPoints()
    {
        return points;
    }
}
