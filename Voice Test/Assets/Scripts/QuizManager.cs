using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    //Variables
    public GameObject[] Quizes;
    private int previousQuiz;
    private int cycleCounter = 10;

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
            cycleCounter -= 1;
            cycleCheck();
            Quizes[rando].SetActive(true);
            drawnQuiz = rando;
        }

    }

    void cycleCheck()
    {
        if (cycleCounter <= 0)
        {
            print("Cycle complete.");
        }
        else
        {
            print("Cycle check complete.");
        }
    }

}
//All code written by Jay Underwood (deShalom)