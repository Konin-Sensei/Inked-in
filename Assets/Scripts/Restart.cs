﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	
	string scene;

	void Start () {
		scene = SceneManager.GetActiveScene().name;
	}
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (scene);
		}
	}
}