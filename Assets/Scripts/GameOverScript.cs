using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	public Text scoreText;
	public Text bestScoreText;

	void Start () 
	{
        this.scoreText.text = PlayerPrefs.GetInt("Score") +"";
        this.bestScoreText.text = PlayerPrefs.GetInt("BestScore") +"";
	}

    public void LoadLevel() 
    {
        Application.LoadLevel(1);
    }
}
