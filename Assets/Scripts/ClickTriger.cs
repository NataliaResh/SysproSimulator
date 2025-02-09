using UnityEngine;

public class ClickTriger : MonoBehaviour
{
    public int countClicks = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            countClicks++;
        }
    }
}
