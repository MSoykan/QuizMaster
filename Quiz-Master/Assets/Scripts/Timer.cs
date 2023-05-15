using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    float timerValue;

    public bool loadNextQuestion;
    public bool isAnsweringQuestions = false;
    public float fillFraction;

    void Update()
    {
        UpdateTimer();
    }


    public void CancelTimer()
    {
        timerValue = 0;
    }
    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;


        if (isAnsweringQuestions)
        {
            if( timerValue>0 )
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else 
            {
                isAnsweringQuestions = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if( timerValue > 0 )
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else 
            {
                isAnsweringQuestions = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }

        


        Debug.Log(isAnsweringQuestions + ": " + timerValue + " = "+fillFraction);
    }
}
