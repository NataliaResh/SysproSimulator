using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlinkigShell : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text textMeshPro;

    private void Start()
    {
        StartCoroutine(Blink());
    }

    private void OnEnable()
    {
        StartCoroutine(Blink());
    }

    private IEnumerator Blink()
    {
        while (true)
        {
            textMeshPro.text = ">";
            yield return new WaitForSeconds(.5f);
            textMeshPro.text = "> _";
            yield return new WaitForSeconds(.5f);
        }
    }
}
