using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;
using System;
using Random = UnityEngine.Random;

public class VoiceRec : MonoBehaviour
{
    //Variables
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    GameObject currentQuiz;
    string quizName;
    public GameObject gameMan;

    //Methods
    private void Start()
    {
        actions.Add("sparrow hawk", hawkSaid);
        actions.Add("cuckoo", hawkSaid);
        actions.Add("robin", hawkSaid);
        actions.Add("peregrine falcon", hawkSaid);
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += recognisedWord;
        keywordRecognizer.Start();
        gameMan.GetComponent<QuizManager>().nextQuiz();
    }

    void hawkSaid()
    {
        print("Fly you fools");
    }

    void recognisedWord(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        quizCheck();

        if (speech.text == quizName)
        {
            actions[speech.text].Invoke();
            currentQuiz.SetActive(false);
            gameMan.GetComponent<RewardManager>().correctChoiceReward(10);
            gameMan.GetComponent<QuizManager>().nextQuiz();
        }
        else
        {
            print("Wrong word silly!");
            currentQuiz.SetActive(false);
            gameMan.GetComponent<RewardManager>().correctChoiceReward(0);
            gameMan.GetComponent<QuizManager>().nextQuiz();
        }

    }

    void quizCheck()
    {
        currentQuiz = GameObject.FindWithTag("Quiz");
        quizName = currentQuiz.name;
    }

}
//All code written by Jay Underwood (deShalom)