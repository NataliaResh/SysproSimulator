using UnityEngine;

public class SpawnerHoles : MonoBehaviour
{
    [SerializeField]
    private GameObject hole;

    private RaycastHit hit;
    public void CreateHole()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 15))
        {
            print(hit.point);
            var obj = Instantiate(hole);
            obj.transform.position = hit.point;
        }
    }

    private void Start()
    {
        CreateHole();
    }
}
