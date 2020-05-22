using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;
using System;

public class VoiceRec : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    GameObject currentQuiz;
    string quizName;

    private void Start()
    {
        actions.Add("sparrow hawk", hawkSaid);
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += recognisedWord;
        keywordRecognizer.Start();
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
            print("This lil bitch works my guy");
            actions[speech.text].Invoke();
        }

    }

    void quizCheck()
    {
        currentQuiz = GameObject.FindWithTag("Quiz");
        quizName = currentQuiz.name;
        print(quizName + "Quiz Check");
    }

}