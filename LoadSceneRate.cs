using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneRate : MonoBehaviour {

	public void LoadRate() {

		SceneManager.LoadScene("Rate");
	}

	public void BackRate() {

		SceneManager.LoadScene("Options");
	}

}