using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAR : MonoBehaviour
{

	public void LoadAR() {

		SceneManager.LoadScene("AR");
	}

	public void BackAR() {

		SceneManager.LoadScene("Options");
	}

}