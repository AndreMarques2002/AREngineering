using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneVideos : MonoBehaviour {

	public void LoadVideos() {

		SceneManager.LoadScene("Videos");
	}

	public void BackVideos() {

		SceneManager.LoadScene("Options");
	}

}