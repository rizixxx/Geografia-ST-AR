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
    private double points = 0;
    public Button reload;
    private void Start()
    {
        generateQuestion();
        ob = new AnswerScript();
        mypoints = GameObject.FindGameObjectWithTag("Points").GetComponent<Text>();
        mymessage = GameObject.FindGameObjectWithTag("Score_Message").GetComponent<Text>();
        reload.gameObject.SetActive(false);
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
            reload.gameObject.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("Board"));
            message();
            canv.GetComponent<Canvas>().enabled = true;
            
        }
        points = ob.getPoints();
        mypoints.text = points.ToString();
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
        
        if (points <= 50)
        {
            mymessage.text = "<b>����������� ����!</b> \n\n�� ���� ��� ����� <b>" + points + "/100</b> ������!";
        }
        else if (points <= 62.5)
        {
            mymessage.text = "<b>������ ����!</b> \n\n�� ���� ��� ����� <b>" + points + "/100</b> ������!";
        }
        else if (points <= 75)
        {
            mymessage.text = "<b>����!</b> \n\n�� ���� ��� ����� <b>" + points + "/100</b> ������!";
        }
        else if (points <= 87.5)
        {
            mymessage.text = "<b>���� ����!</b> \n\n�� ���� ��� ����� <b>" + points + "/100</b> ������!";
        }
        else 
        {
            mymessage.text = "<b>������!</b> \n\n�� ���� ��� ����� \n<b>" + points + "/100</b> ������!";
        }
    }

}
