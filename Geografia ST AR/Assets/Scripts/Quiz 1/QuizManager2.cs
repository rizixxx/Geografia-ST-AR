using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager2 : MonoBehaviour
{
    public List<QuestionAndAnswers2> Qna;
    public GameObject[] options;
    public int currentQuestion;
    private  int index = 0;
    public TextMeshProUGUI QuestionText;
    private AnswerScript2 ob;
    public GameObject canv;
    private Text mypoints;
    private Text mymessage;
    private double points = 0;
    private void Start()
    {
        generateQuestion();
        ob = new AnswerScript2();
        mypoints = GameObject.FindGameObjectWithTag("Points").GetComponent<Text>();
        mymessage = GameObject.FindGameObjectWithTag("Score_Message").GetComponent<Text>();
    }

    public  void correct()
    {
        index++;
        Qna.RemoveAt(currentQuestion);
        if (index < 10)
        {
            generateQuestion();
        }
        else
        {
            points = ob.getPoints();
            Destroy(GameObject.FindGameObjectWithTag("Board"));
            message();
            canv.GetComponent<Canvas>().enabled = true;      
        }
        points = ob.getPoints();
        Debug.Log(points.ToString());
        mypoints.text = points.ToString();
    }
    void setAnswers()
    {
        for (int i =0; i< options.Length; i++)
        {
            
            options[i].GetComponent<AnswerScript2>().isCorrect = false;
            options[i].SetActive(true);
            
            if(Qna[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript2>().isCorrect = true;
            }
        }
    }
    void generateQuestion()
    {
        currentQuestion = Random.Range(0, Qna.Count);

        QuestionText.text = Qna[currentQuestion].Question;
        setAnswers();

    }
    public void message()
    {
        
        if (points <= 50)
        {
            mymessage.text = "<b>Προσπαθήστε ξανά!</b> \n\nΤο σκορ σας είναι <b>" + points + "/100</b> πόντοι!";
        }
        else if (points <= 62.5)
        {
            mymessage.text = "<b>Σχεδόν καλά!</b> \n\nΤο σκορ σας είναι <b>" + points + "/100</b> πόντοι!";
        }
        else if (points <= 75)
        {
            mymessage.text = "<b>Καλά!</b> \n\nΤο σκορ σας είναι <b>" + points + "/100</b> πόντοι!";
        }
        else if (points <= 87.5)
        {
            mymessage.text = "<b>Πολύ καλά!</b> \n\nΤο σκορ σας είναι <b>" + points + "/100</b> πόντοι!";
        }
        else 
        {
            mymessage.text = "<b>Άριστα!</b> \n\nΤο σκορ σας είναι \n<b>" + points + "/100</b> πόντοι!";
        }
    }
   
}
