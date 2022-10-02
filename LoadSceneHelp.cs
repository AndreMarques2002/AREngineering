using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneHelp : MonoBehaviour {

	public void LoadHelp() {

		SceneManager.LoadScene("Help");
	}

	public void BackHelp() {

		SceneManager.LoadScene("Options");
	}
}

