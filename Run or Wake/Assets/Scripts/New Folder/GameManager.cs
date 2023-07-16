using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score;
    public static GameManager inst;
    //
    [SerializeField] TMP_Text scoreText;
    //
    [SerializeField] PlayerController playerController;



    public void IncrementScore ()
    {
        score++;
        scoreText.text = "SCORE: " + score;
        //**//
        playerController.speed += playerController.speedIncreasePerPoint;

    }

    private void Awake()
    {
        inst = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
