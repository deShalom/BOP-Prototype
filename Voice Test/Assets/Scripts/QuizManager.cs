using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public GameObject[] Quizes;

    public void nextQuiz()
    {
        int rando = Random.Range(1, Quizes.Length);
        Quizes[rando].SetActive(true);
    }

}
