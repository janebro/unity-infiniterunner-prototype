using UnityEngine;
using System.Collections;
using System;

public class StartGameScript : MonoBehaviour {

    public void LoadGame() 
    {
        PlayerPrefs.SetInt("BestScore", 0);
        Application.LoadLevel(1);
    }
}
