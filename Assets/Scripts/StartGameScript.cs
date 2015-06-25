using UnityEngine;
using System.Collections;
using System;

public class StartGameScript : MonoBehaviour {

    public AudioClip SFX;

    public void LoadGame() 
    {
        PlayerPrefs.SetInt("BestScore", 0);
        gameObject.GetComponent<AudioSource>().PlayOneShot(SFX);
        Application.LoadLevel(1);
    }
}
