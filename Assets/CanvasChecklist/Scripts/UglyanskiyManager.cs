using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UglyanskiyManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private List<GameObject> uglyan = new List<GameObject>();
    private int current = 2;
    void Start()
    {
        foreach (GameObject obj in uglyan)
        {
            obj.SetActive(false);
        }
        uglyan[current].SetActive(true);
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
}
