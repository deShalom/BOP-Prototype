using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class QuizManager : MonoBehaviour
{
    //Variables
    public GameObject[] Quizes;
    private int previousQuiz;
    private int cycleCounter = 11;
    public GameObject gameMan;

    public Text counter;

    //End of quiz variables
    public GameObject eogPanel, qPanel;
    public TextMeshProUGUI t1, t2, t3;

    public int drawnQuiz
    {
        get { return previousQuiz; }
        set { previousQuiz = value; }
    }

    //Methods
    public void nextQuiz(int cOne, int cTwo)
    {
        int rando = Random.Range(0, Quizes.Length);

        if (rando == drawnQuiz)
        {
            nextQuiz(cOne, cTwo);
        }
        else
        {
            cycleCounter -= 1;
            cycleCheck(cOne, cTwo);
            Quizes[rando].SetActive(true);
            drawnQuiz = rando;
        }

    }

    void cycleCheck(int cOne, int cTwo)
    {
        if (cycleCounter <= 0)
        {
            print("Cycle complete.");
            gameMan.GetComponent<RewardManager>().updateScore();
            qPanel.SetActive(false);
            eogPanel.SetActive(true);
            t1.text = PlayerPrefs.GetFloat("GlobalScore").ToString();
            t2.text = cOne.ToString();
            t3.text = cTwo.ToString();
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