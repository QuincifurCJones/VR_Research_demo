using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Reset_Button : MonoBehaviour
{
    public InputActionReference Button;

    void Start()
    {
        Button.action.performed += reload;
    }

    void reload(InputAction.CallbackContext __)
    {
        //Debug.Log("MOVE TO NEXT SCENE");
        int num = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(num);
    }
}
