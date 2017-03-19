using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    float start_time;
    public Text scoreText;  // public if you want to drag your text object in there manually
    // Use this for initialization
    void Start () {
        start_time = Time.time;
        scoreText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        int score = (int) (Time.time - start_time );
        scoreText.text ="Score: " + score.ToString();
    }
}
