﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart_game : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	public void NextScene()
	{
		SceneManager.LoadScene("Menu");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
