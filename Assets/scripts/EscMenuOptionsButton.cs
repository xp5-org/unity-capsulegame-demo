﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


using System.Net;
using System;
using System.IO;

public class EscMenuOptionsButton : MonoBehaviour
{
    int n;
    public void OnButtonPress()
    {
        n++;
        Debug.Log("Esc-Menu Options Button clicked " + n + " times.");

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Format("https://reqbin.com/echo/get/json"));
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        Debug.Log(jsonResponse);

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 1.25f, -4);

    }
}