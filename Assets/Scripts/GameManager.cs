using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int DegreeMood = 2;
    private int countAnswers = 0;
    private int countCorrectAnswers = 0;
    void Start()
    {
        //StartCoroutine();
    }

    private void IncreaseDegreeMood()
    {
        if (DegreeMood < 5)
        {
            DegreeMood++;
        }
    }

    private void ReduceDegreeMood()
    {
        if (DegreeMood > 0)
        {
            DegreeMood--;
        }
    }

    public void CorrectAnswer()
    {
        IncreaseDegreeMood();
        countCorrectAnswers++;
    }

    public void IncorrectAnswer()
    {
        IncreaseDegreeMood();
    }
}
