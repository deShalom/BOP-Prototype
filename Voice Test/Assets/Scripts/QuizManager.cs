using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuizManager : MonoBehaviour
{
    //Variables
    public GameObject[] Quizes;
    private int previousQuiz;
    private int cycleCounter = 10;
    public GameObject gameMan;

    public Text counter;

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
            gameMan.GetComponent<RewardManager>().updateScore();
        }
        else
        {
            print("Cycle check complete.");
        }
    }

    private void Update()
    {
        counter.text = cycleCounter.ToString();
    }
}
//All code written by Jay Underwood (deShalom)