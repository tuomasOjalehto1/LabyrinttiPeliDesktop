using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiHyokkays : MonoBehaviour
{
    PlayerHealth playerHealth;
    public int vahinko = 5;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collision is with the player
        if (other.CompareTag("Player"))
        {
            playerHealth.TakeDamage(vahinko);
        }
    }
}
