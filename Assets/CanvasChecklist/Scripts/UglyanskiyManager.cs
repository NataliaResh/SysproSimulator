using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UglyanskiyManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private List<GameObject> uglyan = new List<GameObject>();
    void Start()
    {
        foreach (GameObject obj in uglyan)
        {
            obj.SetActive(false);
        }
        uglyan[2].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
