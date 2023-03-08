using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuEditor : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject Instructions;
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
        }
        else
        {
            mainMenu.SetActive(false);
            Instructions.SetActive(true);
        }
    }
}
