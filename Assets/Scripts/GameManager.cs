using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private LabyrinttiLuojaScript labyrinttiLuoja;

    [SerializeField]
    private GameObject pelaajaHahmo;

    // Start is called before the first frame update
    void Start()
    {
        //Annetaan labyrintin valmistua rauhassa.
        Invoke("InstantiatePelaaja", 1.0f);
    }


    public void InstantiatePelaaja(GameObject playerCharacterPrefab)
    {
        labyrinttiLuoja.InstantiatePelaaja(pelaajaHahmo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
