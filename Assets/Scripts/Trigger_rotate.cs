using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class Trigger_rotate : MonoBehaviour
{
    [SerializeField] GameObject Island_enpty;
    [SerializeField] GameObject Hand_control;
    [SerializeField] float min_dist = 0.25f;
    [SerializeField] float angle_scale = 1.0f;
    public InputActionReference Center_input;
    public InputActionReference Track_input;

    public Vector3 previous_point = Vector3.zero;
    public float rotate_timer = 0.0f;
    public float angle = 0.0f;
    private bool toggel = false;

    // Update is called once per frame
    void Update()
    {
        //stick_move.action.performed += Turn;
        //Center_input.action.performed += set_center;
        Track_input.action.performed += set_T;
        Track_input.action.canceled += set_F;

        if(toggel)
        {
            track_hand();
        }
    }

    void track_hand()
    {
        Vector3 new_pos = transform.position;
        float dist = Vector3.Distance(new_pos, previous_point);

        if(dist >= min_dist)
        {
            float sign = 1.0f;
            if(new_pos.x - previous_point.x > 0)
            {
                sign = -1.0f;
            }

            previous_point = new_pos;
            Island_enpty.transform.rotation *= Quaternion.Euler(0, sign*dist* angle_scale, 0);
        }
    }
    void set_T(InputAction.CallbackContext context)
    {
        toggel = true;

        Vector3 new_pos = transform.position;
        previous_point = new_pos;
    }
    void set_F(InputAction.CallbackContext context)
    {
        toggel = false;
    }
}
