using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	public Text scoreText;
	public Text bestScoreText;
    public AudioClip SFX;

	void Start () 
	{
        this.scoreText.text = PlayerPrefs.GetInt("Score") +"";
        this.bestScoreText.text = PlayerPrefs.GetInt("BestScore") +"";
        gameObject.GetComponent<AudioSource>().PlayOneShot(SFX);
	}

    public void LoadLevel() 
    {
        Application.LoadLevel(1);
    }
}
