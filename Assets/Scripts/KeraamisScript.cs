using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class KeraamisScript : MonoBehaviour
{
    public int countTO = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp1") || other.gameObject.CompareTag("PickUp2"))
        {
            other.gameObject.SetActive(false);
            //Laskuri pisteille
            countTO = countTO + 1;
            //SetCountText();
        }

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
