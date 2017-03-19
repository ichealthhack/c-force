using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choice_load_game : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	public void NextScene()
	{
		SceneManager.LoadScene("main");
	}


	// Update is called once per frame
	void Update () {
		
	}
}
