using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Controls : MonoBehaviour
{
    public InputActionReference Right_Stick;
    public InputActionReference Jump_button;
    [SerializeField] public float jump_value = 1.0f;
    [SerializeField] public float move_scale = 1.0f;

    // Update is called once per frame
    void Update()
    {
        Right_Stick.action.performed += Move_player;
        Jump_button.action.performed += jump;
    }

    void Move_player(InputAction.CallbackContext context)
    {
        Vector2 stick_input = context.ReadValue<Vector2>();

        gameObject.transform.position += new Vector3(Math.Sign(stick_input.x) * move_scale, 0, Math.Sign(stick_input.y) * move_scale);
    }

    void jump(InputAction.CallbackContext context)
    {
        gameObject.transform.position += new Vector3(0, jump_value, 0);
    }
}
