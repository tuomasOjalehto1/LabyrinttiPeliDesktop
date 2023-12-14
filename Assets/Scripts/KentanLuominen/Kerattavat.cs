using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kerattavat : MonoBehaviour
{
    [SerializeField]
    LabyrinttiLuojaScript labyrinttiLuojaScript;
    GameManager gameManager;

    [SerializeField]
    GameObject kerattava1Prefab;
    [SerializeField]
    GameObject kerattava2Prefab;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateKerattavaOnGrid();
    }

    private int numberOfGems = 50;
    // Instantiate kerattava1Prefab on each grid cell
    //private void InstantiateKerattavaOnGrid()
    //{
    //    if (labyrinttiLuojaScript == null)
    //    {
    //        Debug.LogError("LabyrinttiLuojaScript is not assigned to Kerattavat script.");
    //        return;
    //    }

    //    for (int x = 0; x < labyrinttiLuojaScript._labyrinttiLeveys; x++)
    //    {
    //        for (int z = 0; z < labyrinttiLuojaScript._labyrinttiSyvyys; z++)
    //        {

    //            if(x == labyrinttiLuojaScript._labyrinttiLeveys -1 &&  z == labyrinttiLuojaScript._labyrinttiSyvyys -1)
    //            {
    //                Instantiate(kerattava2Prefab, new Vector3(x, 0.5f, z), Quaternion.identity);
    //            }
    //            else
    //            {
    //                Instantiate(kerattava1Prefab, new Vector3(x, 0.5f, z), Quaternion.identity);
    //            }
    //        }
    //    }
    //}

    private void InstantiateKerattavaOnGrid()
    {
        if (labyrinttiLuojaScript == null)
        {
            Debug.LogError("LabyrinttiLuojaScript ei ole assignattu tähän");
            return;
        }

        int maxX = labyrinttiLuojaScript._labyrinttiLeveys;
        int maxZ = labyrinttiLuojaScript._labyrinttiSyvyys;

        for (int i = 0; i < numberOfGems; i++)
        {
            int randomX = Random.Range(0, maxX);
            int randomZ = Random.Range(0, maxZ);

            GameObject gemPrefab = (Random.Range(0, 2) == 0) ? kerattava1Prefab : kerattava2Prefab;

            Instantiate(gemPrefab, new Vector3(randomX, 0.5f, randomZ), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Your update logic here
    }
}
