using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //message displayed to player when looking at an interractabale
    public string promptMessage;

    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {

    }
}
