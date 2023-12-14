using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieVahinko : MonoBehaviour
{
    UI ui;
    
    public int zombieHP = 10;
   
    

    Animator zombieAnimator;

    public GameObject zombie;
    // Start is called before the first frame update
    void Start()
    {
        zombieAnimator = GetComponent<Animator>();
        ui = GetComponent<UI>();
    }

    // Update is called once per frame
   public void Update()
    {
        if (zombieHP <= 0)
        {
            //destroyedZombies++;

            zombieAnimator.Play("Z_FallingBack");
            GetComponent<Collider>().enabled = false;

            
            Destroy(zombie, zombieAnimator.GetCurrentAnimatorStateInfo(0).length);
            //Debug.Log(destroyedZombies);
        }

        
    }

   

    public void ZombieOttaaOsumaa(int damage)
    {
        Debug.Log("Zombie otti osumaa");
        zombieHP -= damage;
        
    }

}