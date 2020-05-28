using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour
{
    //Variables
    public GameObject mMenu, setMenu, sMenu, vMenu;

    //Methods
    private void switchPanels(int switchVal)
    {
        switch (switchVal)
        {
            case 1:
                print("Case 1 Chosen");
                mMenu.SetActive(true);
                setMenu.SetActive(false);
                break;
            case 2:
                print("Case 2 Chosen");
                mMenu.SetActive(false);
                setMenu.SetActive(true);
                sMenu.SetActive(true);
                vMenu.SetActive(false);
                break;
            case 3:
                print("Case 3 Chosen");
                mMenu.SetActive(false);
                setMenu.SetActive(true);
                sMenu.SetActive(false);
                vMenu.SetActive(true);
                break;
        }
    }

    public void soundSettingsOpened()
    {
        switchPanels(2);
    }

    public void videoSettingsOpened()
    {
        switchPanels(3);
    }

    public void mainMenuOpen()
    {
        switchPanels(1);
    }
}
//All code written by Jay Underwood (deShalom)