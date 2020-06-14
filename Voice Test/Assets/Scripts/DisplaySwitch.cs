using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DisplaySwitch : MonoBehaviour
{
    //Variables
    public GameObject robinPage, sHawkPage, bOwlPage, merlinPage;
    public int PageCounter = 0;

    //Methods
    private void Awake()
    {
        switchPages(PageCounter);
    }
    void switchPages(int sVal)
    {
        switch (sVal)
        {
            case 0:
                disableAll();
                robinPage.SetActive(true);
                break;
            case 1:
                disableAll();
                sHawkPage.SetActive(true);
                break;
            case 2:
                disableAll();
                bOwlPage.SetActive(true);
                break;
            case 3:
                disableAll();
                merlinPage.SetActive(true);
                break;
        }
    }

    void disableAll()
    {
        try { GameObject fake = GameObject.FindGameObjectWithTag("DPage"); fake.SetActive(false); }
        catch (NullReferenceException) { print("Null"); }
    }

    public void menuSwitchRight()
    {
        if (PageCounter == 3) { PageCounter = 0; switchPages(PageCounter); } else { PageCounter++; switchPages(PageCounter); }
    }

    public void menuSwitchLeft()
    {
        if (PageCounter == 0) { PageCounter = 3; switchPages(PageCounter); } else { PageCounter--;  switchPages(PageCounter); }
    }

}
