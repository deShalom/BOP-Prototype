using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    //Variables
    public GameObject[] Quizes;
    private int previousQuiz;

    public int drawnQuiz
    {
        get { return previousQuiz; }
        set { previousQuiz = value; }
    }

    //Methods
    public void nextQuiz()
    {
        int rando = Random.Range(0, Quizes.Length);

        if (rando == drawnQuiz)
        {
            nextQuiz();
        }
        else
        {
            Quizes[rando].SetActive(true);
            drawnQuiz = rando;
        }

    }

}
//All code written by Jay Underwood (deShalom)