using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class final_score : MonoBehaviour {
    public Text scoreText;
    // Use this for initialization
    void Start() {
        int score1 = PlayerPrefs.GetInt("Score");
        scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + score1.ToString();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
        