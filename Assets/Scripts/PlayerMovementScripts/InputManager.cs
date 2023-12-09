using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    //Class variabelit scripteille
    public PlayerInputFPS playerInput;
    private PlayerInputFPS.OnFootActions onFoot;

    private PlayerMotor motor;
    private PlayerLook look;

    // Start is called before the first frame update
    void Awake()
    {
        //Her‰tell‰‰n objektit
        playerInput = new PlayerInputFPS();
        onFoot = playerInput.OnFoot;

        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();

        //ctx = callback context
        onFoot.Jump.performed += ctx => motor.Jump();

        onFoot.Crouch.performed += ctx => motor.Crouch();
        onFoot.Sprint.performed += ctx => motor.Sprint();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Kertoo pelaajamoottorille ett‰ nyt tulee liikkua.
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        // Add a check for null before calling Disable
        if (onFoot.Movement != null)
        {
            onFoot.Disable();
        }
    }


}
