using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UglyanskiyManager manager;
    [SerializeField]
    private GameObject holePrefab;

    private int DegreeMood = 2;
    //private int countAnswers = 0;
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
        manager.Next();
        countCorrectAnswers++;
    }

    public void IncorrectAnswer()
    {
        IncreaseDegreeMood();
        manager.Back();
    }

    public void BadEnd()
    {
        var hole = Instantiate(holePrefab);
        hole.transform.position = new Vector3(0.07f, 0, -1.21f);
        manager.BadEnd();
    }

    public void End(int countAnswers)
    {
        if (countCorrectAnswers / countAnswers > 0.7f)
        {
            manager.GoodEnd();
        }
        else if (countCorrectAnswers / countAnswers > 0.5f)
        {
            manager.NoGoodEnd();
        }
        else
        {
            BadEnd();
        }
    }
}
