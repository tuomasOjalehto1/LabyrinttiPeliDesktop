using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Ase : MonoBehaviour
{
    //[Header("Refernces")]
    //[SerializeField] AseData aseData;

    private PlayerUI playerUI;
    private InputManager inputManager;
    private PlayerInteract playerInteract;
    private ZombieVahinko zombieVahinko;
    private UI ui;

    float timeSinceLastShot;

    public GameObject suuLiekki;

    //Aseen jutut
    private int panokset = 8;


    private void Start()
    {
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
        playerInteract = GetComponent<PlayerInteract>();
        zombieVahinko = GetComponent<ZombieVahinko>();
        ui = GetComponent<UI>();
    }

    private void Update()
    {
        if(inputManager.playerInput.OnFoot.Shoot.triggered)
        {
            //Debug.Log("Näppäintä painettu");
            Shoot();
        }
        timeSinceLastShot += Time.deltaTime;

        if(inputManager.playerInput.OnFoot.Reload.triggered)
        {
            Reload();
        }

    }

    private bool VoikoAmpuu()
    {
        return true;
    }
    public void Shoot()
    {
        if (panokset > 0)
        {
           if (VoikoAmpuu())
            {
                suuLiekki.SetActive(true);
                GameObject suuLiekkiInstantiate = Instantiate(suuLiekki, suuLiekki.transform.position, Quaternion.identity);
                Destroy(suuLiekkiInstantiate,0.1f);
                suuLiekki.SetActive(!true);

                Debug.Log("Laukaus");
                if(playerInteract.osuukoSadeInterractableen)
                {
                    Debug.Log("Osuu interactableen");
                    //luodaan instanssi kyseisen zombin vahingosta
                    ZombieVahinko zombieVahinko = playerInteract.currentInteractable.GetComponent<ZombieVahinko>();
                    zombieVahinko.ZombieOttaaOsumaa(5);
                    

                }
                panokset--;
                timeSinceLastShot = 0;
                OnGunShot();
            }
        }
    }

    public void Reload()
    {
        panokset = 8;
    }

    private void OnGunShot()
    {
       
    }
    
}
