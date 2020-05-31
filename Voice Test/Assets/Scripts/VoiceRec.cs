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
    int correctCounter, incorrectCounter;
    //Methods
    private void Start()
    {
        actions.Add("sparrow hawk", hawkSaid);
        actions.Add("cuckoo", hawkSaid);
        actions.Add("robin", hawkSaid);
        actions.Add("peregrine falcon", hawkSaid);
        actions.Add("barn owl", hawkSaid);
        actions.Add("buzzard", hawkSaid);
        actions.Add("golden eagle", hawkSaid);
        actions.Add("kestrel", hawkSaid);
        actions.Add("merlin", hawkSaid);
        actions.Add("ospray", hawkSaid);
        actions.Add("red kite", hawkSaid);
        actions.Add("tawny owl", hawkSaid);
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += recognisedWord;
        keywordRecognizer.Start();
        gameMan.GetComponent<QuizManager>().nextQuiz(correctCounter, incorrectCounter);

        //Move to awake if possible
        gameMan.GetComponent<RewardManager>().checkScores();
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
            correctCounter++;
            actions[speech.text].Invoke();
            currentQuiz.SetActive(false);
            gameMan.GetComponent<RewardManager>().correctChoiceReward(10);
            gameMan.GetComponent<QuizManager>().nextQuiz(correctCounter, incorrectCounter);
        }
        else
        {
            incorrectCounter++;
            print("Wrong word silly!");
            currentQuiz.SetActive(false);
            gameMan.GetComponent<RewardManager>().correctChoiceReward(0);
            gameMan.GetComponent<QuizManager>().nextQuiz(correctCounter, incorrectCounter);
        }

    }

    void quizCheck()
    {
        currentQuiz = GameObject.FindWithTag("Quiz");
        quizName = currentQuiz.name;
    }

}
//All code written by Jay Underwood (deShalom)