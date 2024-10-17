using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Stick_rotate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Island_enpty;
    public InputActionReference stick_move;
    [SerializeField] int rotate_amount = 5;


    // Update is called once per frame
    void Update()
    {
        stick_move.action.performed += Turn;
    }

    void Turn(InputAction.CallbackContext __)
    {
        Island_enpty.transform.rotation *= Quaternion.Euler(0, rotate_amount, 0);
    }
}
