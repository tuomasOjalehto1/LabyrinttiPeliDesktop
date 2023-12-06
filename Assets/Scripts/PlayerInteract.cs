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
    private LayerMask mask; //Muuttuja sille minkälainen layeri kyseessä


    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
    }

    // Update is called once per frame
    void Update()
    {
        //Ampuu säteen loputtoman kauas. Näkymätön säde.
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);//Määritellään säde ray tyyppiseksi muuttujaksi ja lähtemään kamerasta
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo; //Tänne tallentuu kaikenlaista dataa säteen törmäyksestä johonkin.
        //if lauseen ansionsta vain jos osutaan säteellä johonkin palautuu tietoja.       
        if(Physics.Raycast(ray, out hitInfo,distance, mask))//Metodi joka ottaa sisään säteen ja palauttaa osuman tiedot
        {
            if(hitInfo.collider.GetComponent<Interactable>() != null) 
            {
                Debug.Log(hitInfo.collider.GetComponent<Interactable>().promptMessage);
            }
        }
    }
}
