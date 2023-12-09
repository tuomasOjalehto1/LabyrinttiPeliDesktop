using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UIElements;

public class DamageEffect : MonoBehaviour
{
    private Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Canvas component
        canvas = GetComponent<Canvas>();

        if (canvas == null)
        {
            Debug.LogError("Canvas component not found.");
        }
    }

    // Function to toggle the canvas on and off
    public IEnumerator DamageEfekti(float delay)
    {
        if (canvas != null)
        {


            canvas.enabled = true;
            Debug.Log("Canvas state toggled. New state: " + canvas.enabled);
            yield return new WaitForSeconds(delay);
            canvas.enabled = false;

        }
        else
        {
            Debug.LogError("Canvas component is null. Make sure it's found.");
        }
    }
}
