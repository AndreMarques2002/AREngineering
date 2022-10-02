using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneGallery : MonoBehaviour {

	public void LoadGallery() {

		SceneManager.LoadScene("Gallery");
	}

	public void BackAbout() {

		SceneManager.LoadScene("AR");
	}

}