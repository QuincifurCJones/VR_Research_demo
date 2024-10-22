using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Stick_rotate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Island_enpty;
    public InputActionReference stick_move;
    [SerializeField] int rotate_amount_X = 5;
    [SerializeField] int rotate_amount_Y = 5;


    // Update is called once per frame
    void Update()
    {
        stick_move.action.performed += Turn;
    }

    void Turn(InputAction.CallbackContext context)
    {
        Vector2 stick_input = context.ReadValue<Vector2>();

        int scale_rotate_x = 0;
        int scale_rotate_y = 0;

        // check X
        if (stick_input.x >= 0.25f)
        {
            scale_rotate_x = 1;
        }
        else if (stick_input.x <= -0.25f)
        {
            scale_rotate_x = -1;
        }

        // check Y
        if (stick_input.y >= 0.25f)
        {
            scale_rotate_y = 1;
        }
        else if (stick_input.y <= -0.25f)
        {
            scale_rotate_y = -1;
        }

        int let_y = 0;

        Island_enpty.transform.rotation *= Quaternion.Euler(0,rotate_amount_X * scale_rotate_x, rotate_amount_Y * scale_rotate_y);
    }

}
