using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class KeraamisScript : MonoBehaviour
{
    public UI ui;

    public int countTO = 0;
    public GameObject partikkeli;
    public void OnTriggerEnter(Collider other)
    {
        GameObject PartikkeliValiObjekti = Instantiate(partikkeli, other.gameObject.transform.position, Quaternion.identity); other.gameObject.SetActive(false);


        if (other.gameObject.CompareTag("PickUp1") || other.gameObject.CompareTag("PickUp2"))
        {
            Debug.Log("Menit sis��n");
            //Laskuri pisteille
            countTO = countTO + 1;
            //ui.timantit += 1;
            Destroy(PartikkeliValiObjekti, 1f);
            //SetCountText();
        }
        else
        {
            return;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        ui = GetComponent<UI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
