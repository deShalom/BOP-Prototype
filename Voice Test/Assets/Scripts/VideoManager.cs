using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour
{
    //Variables
    Dropdown windowedDropdown;

    //Methods
    public void windowedDropdownInput(int val)
    {
        print(val.ToString());

        switch(val)
        {
            case 0:
                print("Fullscreen");
                Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
                break;
            case 1:
                print("Fullscreen windowed");
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
                break;
            case 2:
                print("Windowed");
                Screen.fullScreenMode = FullScreenMode.Windowed;
                break;

        }

    }
}
//All code written by Jay Underwood (deShalom)