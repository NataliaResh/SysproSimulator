using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            print(other.tag);
            other.gameObject.layer = LayerMask.NameToLayer("Hole");
        }
    }
}