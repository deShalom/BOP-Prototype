using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    //Variables
    AsyncOperation async;
    //Methods
    IEnumerator sceneChanger(int sNum)
    {
        async = SceneManager.LoadSceneAsync(sNum);
        yield return null;
    }

    //Load the quiz scene
    public void enterQuiz()
    {
        StartCoroutine(sceneChanger(1));
    }

    //Load the main menu scene
    public void enterMainMenu()
    {
        StartCoroutine(sceneChanger(0));
    }

    //Exit the application
    public void exitGame()
    {
        Application.Quit();
    }

}
//All code written by Jay Underwood (deShalom)