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
        canvas[0].SetActive(true);
    }

    void Update()
    {

    }
    public void NextQuestion(GameObject Button)
    {
        canvas[currentCanvas].SetActive(false);
        currentCanvas++;
        if (Button.gameObject.CompareTag("CorrectAnswer"))
        {
            gameManager.CorrectAnswer();
        }
        else
        {
            gameManager.IncorrectAnswer();
        }
    }
   

}
