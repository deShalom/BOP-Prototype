﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PassTest : MonoBehaviour
{

    private void Awake()
    {
        StartCoroutine(Test());
    }

    IEnumerator Test()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", "Geoff");
        form.AddField("score", 1998);

        //WWW www = new WWW("http://de-shalom.co.uk/donkey.php?", form);
        //yield return www;

        using (UnityWebRequest www = UnityWebRequest.Post("https://de-shalom.co.uk/donkey.php?", form))
        {
            www.chunkedTransfer = false;////ADD THIS LINE
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
            }

        }

    }
}
