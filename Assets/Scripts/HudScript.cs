using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HudScript : MonoBehaviour {

    float playerScore = 0.0f;
    public Text scoreText;

    void Start()
    {
        this.scoreText.text = "Score: 0";
    }

	void Update() 
    {
        playerScore += Time.deltaTime * 10;
        this.scoreText.text = "Score: " + (int) playerScore;
	}

    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int) playerScore);

        if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", PlayerPrefs.GetInt("Score"));
        }
    }
}