using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour
{
    //Variables
    Dropdown windowedDropdown;
    Dropdown resolutionDropdown;

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

    public void resoluationDropdownInput(int val)
    {
        switch (val)
        {
            case 0:
                print("1920 x 1080");
                if (Screen.fullScreenMode == FullScreenMode.ExclusiveFullScreen)
                {
                    Screen.SetResolution(1920, 1080, true);
                }
                else { Screen.SetResolution(1920, 1080, false); }
                break;
            case 1:
                print("800 x 600");
                if (Screen.fullScreenMode == FullScreenMode.ExclusiveFullScreen)
                {
                    Screen.SetResolution(800, 600, true);
                }
                else { Screen.SetResolution(800, 600, false); }
                break;
            case 2:
                print("1536 x 2048");
                if (Screen.fullScreenMode == FullScreenMode.ExclusiveFullScreen)
                {
                    Screen.SetResolution(1536, 2048, true);
                }
                else { Screen.SetResolution(1536, 2048, false); }
                break;
            case 3:
                print("2560 x 1080");
                if (Screen.fullScreenMode == FullScreenMode.ExclusiveFullScreen)
                {
                    Screen.SetResolution(2560, 1080, true);
                }
                else { Screen.SetResolution(2560, 1080, false); }
                break;
        }
    }

}
//All code written by Jay Underwood (deShalom)