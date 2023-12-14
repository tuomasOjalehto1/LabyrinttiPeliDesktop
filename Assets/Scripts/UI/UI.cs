using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    KeraamisScript keraamisScript;
    ZombieVahinko zombieVahinko;

    public int tapot = 0;
    public int timantit = 0;

    public TextMeshProUGUI tapotText;
    public TextMeshProUGUI timantitText;

    // Start is called before the first frame update
    void Start()
    {
        keraamisScript = GetComponent<KeraamisScript>();
        zombieVahinko = GetComponent<ZombieVahinko>();

        if (keraamisScript == null)
            Debug.LogError("KeraamisScript is null!");

        if (zombieVahinko == null)
            Debug.LogError("ZombieVahinko is null!");


        keraamisScript.ui = this;
    }

    // Update is called once per frame
    void Update()
    {
       
        timantit = keraamisScript.countTO;

        tapotText.text = tapot.ToString();
        timantitText.text = timantit.ToString();
    }
}
