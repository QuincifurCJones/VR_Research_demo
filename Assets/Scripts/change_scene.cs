using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class change_scene : MonoBehaviour
{
    [SerializeField] public int scene_num = 0;

    public InputActionReference triggerLeft;
    public InputActionReference triggerRight;

    // Update is called once per frame
    void Update()
    {
        float leftTriggerHeld = triggerLeft.action.ReadValue<float>();
        float rightTriggerHeld = triggerRight.action.ReadValue<float>();

        if (leftTriggerHeld > 0.5 && rightTriggerHeld > 0.5) {
            move_scene();
        }
    }

    void move_scene()
    {
        SceneManager.LoadScene(scene_num);
    }
}
