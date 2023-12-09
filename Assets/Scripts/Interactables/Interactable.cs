using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{   
    //Lis‰‰ tai poista InteractionEvent componentti t‰st‰ gameobjektista
    public bool useEvents;
    [SerializeField]
    public string promptMessage;


    public virtual string OnLook()
    {
        return promptMessage;
    }

    public void BaseInteract()
    {
        Debug.Log("Base Interact metodi kutsuttu");   
        if(useEvents)
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        Interact();
        
    }

    protected virtual void Interact()
    {

    }
}
