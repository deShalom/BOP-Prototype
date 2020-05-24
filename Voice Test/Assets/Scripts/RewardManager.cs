using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardManager : MonoBehaviour
{
    //Variables
    [SerializeField]
    private int m_balance; 
    //UI tester variables
    public Text balDisplay;

    //Methods
    private void Update()
    {
        balDisplay.text = balance.ToString();
    }

    public int balance
    {
        get { return m_balance; }
        set { m_balance = value; }
    }

    public void correctChoiceReward(int reward)
    {
        balance = balance + reward;
    }

    //Implement possibly?
    public void completeQuizReward()
    {
        int randomReward = Random.Range(10, 50);
        balance = balance + randomReward;
    }

    public void checkScores()
    {
        if (!PlayerPrefs.HasKey("GlobalScore"))
        {
            PlayerPrefs.SetFloat("GlobalScore", 0f);
        }
        else
        {
            print(PlayerPrefs.GetFloat("GlobalScore"));
        }
    }

    public void updateScore()
    {
        PlayerPrefs.SetFloat("GlobalScore", PlayerPrefs.GetFloat("GlobalScore") + balance);
        print(PlayerPrefs.GetFloat("GlobalScore"));
    }

}
//All code written by Jay Underwood (deShalom)