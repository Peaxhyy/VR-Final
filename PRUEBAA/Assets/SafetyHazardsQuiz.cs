using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SafetyHazardsQuiz : MonoBehaviour
{
    public GameObject Menu, Q1, Q2, Q3, Q4, Q5, Results;
    public int cont = 0;
    double result = 0;
    public TMP_Text resultsTXT;
    public AnswersSafetyHazards answersSafetyHazards;
    void Start()
    {
        Q1.SetActive(false);
        Q2.SetActive(false);
        Q3.SetActive(false);
        Q4.SetActive(false);
        Q5.SetActive(false);
        Results.SetActive(false);
    }

    void Update()
    {

    }
    public void _finish(){
        Results.SetActive(false);
    }
    public void _ChangeQuestion()
    {
        cont++;
        switch (cont)
        {
            case 1:
                Menu.SetActive(false);
                Q1.SetActive(true);
            break;
            case 2:
                Q1.SetActive(false);
                Q2.SetActive(true);
            break;
            case 3:
                Q2.SetActive(false);
                Q3.SetActive(true);
            break;
            case 4:
                Q3.SetActive(false);
                Q4.SetActive(true);
            break;
            case 5:
                Q4.SetActive(false);
                Q5.SetActive(true);
            break;
            case 6:
                Q5.SetActive(false);
                Results.SetActive(true);
                result = (answersSafetyHazards.score / 5)*100;
                resultsTXT.text = "Your score is : "+ result+"%";
            break;
        }
    }
}