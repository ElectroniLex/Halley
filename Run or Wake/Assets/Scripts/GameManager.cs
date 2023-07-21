using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score;
    public static GameManager inst;
    //
    [SerializeField] TMP_Text scoreText;
    //
    [SerializeField] PlayerController playerController;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
        //Debug.Log(score);
        // Increase the player's speed
        playerController.speed += playerController.speedIncreasePerPoint;
    }

    private void Awake ()
    {
        inst = this;
    }

    private void Start () {

	}

	private void Update () {
	
	}
}
