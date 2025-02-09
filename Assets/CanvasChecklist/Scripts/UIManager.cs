using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class UIManager : MonoBehaviour
{
    private RaycastHit hit;
    private GameObject sphere;

    [SerializeField]
    private LineRenderer lineRenderer;

    [SerializeField]
    private Material redMat;
    [SerializeField]
    private Material greenMat;

    [SerializeField]
    private SteamVR_Action_Boolean uiAction;

    private bool readyToPress = false;

    private void Start()
    {
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = Vector3.one * 0.03f;
        Destroy(sphere.GetComponent<Collider>());
    }
    private void Update()
    {
        lineRenderer.SetPosition(0, transform.position);
        if (Physics.Raycast(transform.position, transform.forward, out hit, 30))
        {
            
            if (hit.collider.gameObject.layer != LayerMask.NameToLayer("UI"))
            {
                lineRenderer.enabled = false;
                sphere.SetActive(false);
                lineRenderer.material = redMat;
                readyToPress = false;
                return;
            }
            lineRenderer.enabled = true;
            lineRenderer.SetPosition(1, hit.point);
            lineRenderer.material = greenMat;
            sphere.SetActive(true);
            sphere.transform.position = hit.point;
            readyToPress = true;
        }
        else
        {
            sphere.SetActive(false);
            lineRenderer.enabled = false;
            readyToPress = false;
        }

        if (uiAction.GetStateDown(SteamVR_Input_Sources.RightHand) && readyToPress || Input.GetKeyDown(KeyCode.Q) && readyToPress)
        {
            if (hit.collider.GetComponent<VRButton>())
            {
                hit.collider.GetComponent<VRButton>().Press();
            }
        }
    }
}