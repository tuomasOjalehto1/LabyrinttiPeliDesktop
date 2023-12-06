using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float distance = 5f;
    [SerializeField]
    private LayerMask mask; //Muuttuja sille mink�lainen layeri kyseess�


    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
    }

    // Update is called once per frame
    void Update()
    {
        //Ampuu s�teen loputtoman kauas. N�kym�t�n s�de.
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);//M��ritell��n s�de ray tyyppiseksi muuttujaksi ja l�htem��n kamerasta
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo; //T�nne tallentuu kaikenlaista dataa s�teen t�rm�yksest� johonkin.
        //if lauseen ansionsta vain jos osutaan s�teell� johonkin palautuu tietoja.       
        if(Physics.Raycast(ray, out hitInfo,distance, mask))//Metodi joka ottaa sis��n s�teen ja palauttaa osuman tiedot
        {
            if(hitInfo.collider.GetComponent<Interactable>() != null) 
            {
                Debug.Log(hitInfo.collider.GetComponent<Interactable>().promptMessage);
            }
        }
    }
}
