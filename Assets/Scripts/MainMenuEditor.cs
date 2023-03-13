using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuEditor : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject Instructions;
    public GameObject controller;
    public GameObject keyboard;
    public GameObject switchToControllerMethod;
    public GameObject switchToKeyboardMethod;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void whenButtonClicked()
    {
        if (Instructions.activeInHierarchy == true)
        {
            mainMenu.SetActive(true);
            Instructions.SetActive(false);
            controller.SetActive(false);
            //switchToControllerMethod.SetActive(true);
           // switchToKeyboardMethod.SetActive(false);
        }
        else
        {
            mainMenu.SetActive(false);
            Instructions.SetActive(true);
            keyboard.SetActive(true);
            //switchToControllerMethod.SetActive(false);
           // switchToKeyboardMethod.SetActive(true);
        }
    }

    public void SwitchControllerScheme()
    {
        if (Instructions.activeInHierarchy == true)
        {
            controller.SetActive(true);
            keyboard.SetActive(false);
           // switchToControllerMethod.SetActive(true);
            //switchToKeyboardMethod.SetActive(false);
        }
        else
        {
            controller.SetActive(false);
            keyboard.SetActive(true);
           // switchToControllerMethod.SetActive(false);
           // switchToKeyboardMethod.SetActive(true);
        }
    }
    public void SwitchKeyboardScheme()
    {
        if (Instructions.activeInHierarchy == true)
        {
            keyboard.SetActive(true);
            controller.SetActive(false);
           // switchToControllerMethod.SetActive(false);
           // switchToKeyboardMethod.SetActive(true);
        }
        else
        {
            keyboard.SetActive(false);
            controller.SetActive(true);
           // switchToControllerMethod.SetActive(true);
            //switchToKeyboardMethod.SetActive(false);
        }
    }
}
