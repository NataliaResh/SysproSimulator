using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UglyanskiyManager manager;
    [SerializeField]
    private GameObject holePrefab;

    [SerializeField]
    private AudioSource[] audioSources;

    private int currentAudio = 0;

    private int DegreeMood = 2;
    //private int countAnswers = 0;
    private int countCorrectAnswers = 0;

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
        audioSources[currentAudio].Play();
        currentAudio = (currentAudio + 1) % audioSources.Length;
    }

    public void IncorrectAnswer()
    {
        ReduceDegreeMood();
        manager.Back();
        audioSources[currentAudio].Play();
        currentAudio = (currentAudio + 1) % audioSources.Length;
    }

    public void BadEnd()
    {
        var hole = Instantiate(holePrefab);
        hole.transform.position = new Vector3(0, 0, -0.78f);
        manager.BadEnd();
    }

    public void End(int countAnswers)
    {
        print(countCorrectAnswers / countAnswers);
        if (countCorrectAnswers / countAnswers > 0.85f)
        {
            manager.GoodEnd();
        }
        else if (countCorrectAnswers / countAnswers > 0.6f)
        {
            manager.NoGoodEnd();
        }
        else
        {
            BadEnd();
        }
    }
}
