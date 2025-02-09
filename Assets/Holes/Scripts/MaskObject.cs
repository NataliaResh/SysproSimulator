using UnityEngine;

public class MaskObject : MonoBehaviour
{

    void Start()
    {
        GameObject.FindGameObjectWithTag("Floor").GetComponent<MeshRenderer>().material.renderQueue = 3002;
    }
}