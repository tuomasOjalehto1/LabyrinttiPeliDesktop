using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    public float xRotation = 0f;

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        //Lasketaan kaeran k��nn�s katsottaessa yl�s ja alas
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80, 80f);
        //Sovitetaan kameran transformiin
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //k��nn� pelaajaa vasemmalle ja oikealle
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
