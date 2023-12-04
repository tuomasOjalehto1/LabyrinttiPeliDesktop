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

    // Instantiate kerattava1Prefab on each grid cell
    private void InstantiateKerattavaOnGrid()
    {
        if (labyrinttiLuojaScript == null)
        {
            Debug.LogError("LabyrinttiLuojaScript is not assigned to Kerattavat script.");
            return;
        }

        for (int x = 0; x < labyrinttiLuojaScript._labyrinttiLeveys; x++)
        {
            for (int z = 0; z < labyrinttiLuojaScript._labyrinttiSyvyys; z++)
            {
                
                if(x == labyrinttiLuojaScript._labyrinttiLeveys -1 &&  z == labyrinttiLuojaScript._labyrinttiSyvyys -1)
                {
                    Instantiate(kerattava2Prefab, new Vector3(x, 0.5f, z), Quaternion.identity);
                }
                else
                {
                    Instantiate(kerattava1Prefab, new Vector3(x, 0.5f, z), Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Your update logic here
    }
}
