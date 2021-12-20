using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> Qna;
    public GameObject[] options;
    public int currentQuestion;
    private  int index = 0;
    public TextMeshProUGUI QuestionText;
    private AnswerScript ob;
    public GameObject canv;
    private Text mypoints;
    private Text mymessage;
    private void Start()
    {
        generateQuestion();
        ob = new AnswerScript();
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
            mypoints.text = ob.getPoints().ToString();
        }
        else
        {
            Destroy(GameObject.FindGameObjectWithTag("Board"));
            message();
            canv.GetComponent<Canvas>().enabled = true;
            
        }
    }
    void setAnswers()
    {
        for (int i =0; i< options.Length; i++)
        {
            
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].SetActive(true);
            try { 
                options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Qna[currentQuestion].Answers[i];
            }
            catch
            {
                options[i].SetActive(false);
            }
            if(Qna[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
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
        double points = ob.getPoints();
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
        if (points <= 100)
        {
            mymessage.text = "<b>Άριστα!</b> \n\nΤο σκορ σας είναι \n<b>" + points + "/100</b> πόντοι!";
        }
    }

}
