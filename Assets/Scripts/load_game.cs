using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


	// Use this for initialization
	public class Control : MonoBehaviour
	{
		public void NextScene()
		{
			SceneManager.LoadScene("GameScene");
		}
	}
	
	// Update is called once per frame
