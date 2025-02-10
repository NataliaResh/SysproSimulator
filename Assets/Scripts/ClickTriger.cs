using UnityEngine;

public class ClickTriger : MonoBehaviour
{
    public int countClicks = 0;
    private void OnTriggerEnter(Collider other)
    {
        //print(other.gameObject.layer);
        if (other.gameObject.layer == LayerMask.NameToLayer("Hand"))
        {
            //print(countClicks);
            countClicks++;
        }
    }
}
