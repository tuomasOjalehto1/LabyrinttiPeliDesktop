using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointitKentalle : MonoBehaviour

{
    [SerializeField]
    public GameObject wayPointPrefab;
    public LabyrinttiLuojaScript labyrinttiLuojaScript;
    public int wayPointtienMaara;
    public GameObject enemyPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        //Varmistetaan ett‰ waypointteja on parillinen m‰‰r‰
        if(wayPointtienMaara % 2 !=0 ) 
        {
            wayPointtienMaara += 1;
        }
        InstantiateWaypointsOnGrid();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InstantiateWaypointsOnGrid()
    {
        if (labyrinttiLuojaScript == null)
        {
            Debug.LogError("LabyrinttiLuojaScript is not assigned to WayPointintKentalle script.");
            return;
        }

        int maxX = labyrinttiLuojaScript._labyrinttiLeveys;
        int maxZ = labyrinttiLuojaScript._labyrinttiSyvyys;

        for (int i = 0; i < wayPointtienMaara; i += 2)
        {
            int randomX1 = Random.Range(0, maxX);
            int randomZ1 = Random.Range(0, maxZ);

            int randomX2 = Random.Range(0, maxX);
            int randomZ2 = Random.Range(0, maxZ);

            Instantiate(wayPointPrefab, new Vector3(randomX1, 0.5f, randomZ1), Quaternion.identity);
            Instantiate(wayPointPrefab, new Vector3(randomX2, 0.5f, randomZ2), Quaternion.identity);

            // Instantiate enemy for each pair of waypoints
            Instantiate(enemyPrefab, new Vector3((randomX1 + randomX2) / 2, 0.5f, (randomZ1 + randomZ2) / 2), Quaternion.identity);
        }
    }

}
