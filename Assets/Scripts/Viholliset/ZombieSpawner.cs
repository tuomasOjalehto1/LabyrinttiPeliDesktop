using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField]
    LabyrinttiLuojaScript labyrinttiLuojaScript;
    GameManager gameManager;


    [SerializeField]
    GameObject zombiePrefab;

    private void Start()
    {
        InstantiateZombieOnGrid();
    }

    private int zombienMaara = 10;

    private void InstantiateZombieOnGrid()
    {
        if(labyrinttiLuojaScript == null)
        {
            Debug.LogError("LabyrinttiLuojaScript ei ole assignattu tähän");
            return;
        }

        int maxX = labyrinttiLuojaScript._labyrinttiLeveys;
        int maxZ = labyrinttiLuojaScript._labyrinttiSyvyys;

        for (int i = 0; i < zombienMaara; i++)
        {
            int randomX = Random.Range(0, maxX);
            int randomZ = Random.Range(0, maxZ);

            Instantiate(zombiePrefab, new Vector3(randomX, 0.08f, randomZ), Quaternion.identity);
        }
    }

    private void Update()
    {
            
    }

}
