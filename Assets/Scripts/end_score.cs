using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_score : MonoBehaviour {

	// Use this for initialization
	void Start () {}
		public void NextScene()
		{
			SceneManager.LoadScene("Score");
		}
		

	
	// Update is called once per frame
	void Update () {
		
	}
}
