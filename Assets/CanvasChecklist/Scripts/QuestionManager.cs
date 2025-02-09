using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionnManager : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private List<GameObject> canvas = new List<GameObject>();


    private int currentCanvas = 0;

    void Start()
    {
        foreach (GameObject obj in canvas)
        {
            obj.SetActive(false);
        }

    }

    public void StartGame()
    {
        canvas[0].SetActive(true);
    }

    public void NextQuestion(GameObject Button)
    {
        if (Button.gameObject.CompareTag("CorrectAnswer"))
        {
            gameManager.CorrectAnswer();
        }
        else
        {
            gameManager.IncorrectAnswer();
        }
        canvas[currentCanvas].SetActive(false);
        currentCanvas++;
        if (currentCanvas == canvas.Count)
        {
            gameManager.End(currentCanvas);
            return;
        }
        canvas[currentCanvas].SetActive(true);
        
    }


}
