using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Jahtaaja : MonoBehaviour
{
    //Ei pysty drag and droppaaman
    public GameObject pelaaja;
    NavMeshAgent agentti;
    // Start is called before the first frame update
    void Start()
    {
        agentti = GetComponent<NavMeshAgent>();
        pelaaja = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        agentti.SetDestination(pelaaja.transform.position);
    }
}