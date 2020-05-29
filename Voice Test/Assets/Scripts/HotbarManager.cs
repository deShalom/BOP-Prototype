using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarManager : MonoBehaviour
{
    //Variables
    public GameObject exitMenu;

    //Methods
    public void toggleExitMenu()
    {
        if (!exitMenu.activeInHierarchy)
        {
            exitMenu.SetActive(true);
        }
        else
        {
            exitMenu.SetActive(false);
        }
    }

}
//All code written by Jay Underwood (deShalom)