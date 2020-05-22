using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;
using System;
using Random = UnityEngine.Random;

public class VoiceRec : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    GameObject currentQuiz;
    string quizName;
    public GameObject[] Quizes;

    private void Start()
    {
        actions.Add("sparrow hawk", hawkSaid);
        actions.Add("cuckoo", hawkSaid);
        actions.Add("robin", hawkSaid);
        actions.Add("peregrine falcon", hawkSaid);
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += recognisedWord;
        keywordRecognizer.Start();
        nextQuiz();
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
            nextQuiz();
        }

    }

    void quizCheck()
    {
        currentQuiz = GameObject.FindWithTag("Quiz");
        quizName = currentQuiz.name;
    }

    void nextQuiz()
    {
        int rando = Random.Range(1, Quizes.Length);
        Quizes[rando].SetActive(true);
    }

}