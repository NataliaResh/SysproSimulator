using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UglyanskiyManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> uglyan = new List<GameObject>();
    private int current = 2;

    [SerializeField]
    private List<GameObject> canvas = new List<GameObject>();
    private int currentCanvas = 0;

    [SerializeField]
    private GameObject goodEnd, noGoodEnd, badEnd;
    void Start()
    {
        foreach (GameObject obj in uglyan)
        {
            obj.SetActive(false);
        }
        uglyan[current].SetActive(true);
        foreach (GameObject obj in canvas)
        {
            obj.SetActive(false);
        }
        canvas[currentCanvas].SetActive(true);
        goodEnd.SetActive(false);
        noGoodEnd.SetActive(false);
        badEnd.SetActive(false);
    }

    public void Next()
    {
        if (current < 4)
        {
            uglyan[current].gameObject.SetActive(false);
            current++;
            uglyan[current].gameObject.SetActive(true);
        }
    }

    public void Back()
    {
        if (current > 0)
        {
            uglyan[current].gameObject.SetActive(false);
            current--;
            uglyan[current].gameObject.SetActive(true);
        }
    }

    public void NextCanvas()
    {
        canvas[currentCanvas].gameObject.SetActive(false);
        currentCanvas++;
        canvas[currentCanvas].gameObject.SetActive(true);
    }

    public void GoodEnd()
    {
        canvas[currentCanvas].gameObject.SetActive(false);
        goodEnd.SetActive(true);
    }

    public void NoGoodEnd()
    {
        canvas[currentCanvas].gameObject.SetActive(false);
        noGoodEnd.SetActive(true);
    }

    public void BadEnd()
    {
        canvas[currentCanvas].gameObject.SetActive(false);
        badEnd.SetActive(true);
    }
}
