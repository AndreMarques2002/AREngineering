using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneTeste : MonoBehaviour
{

	public void LoadTeste()
	{

		SceneManager.LoadScene("About");
	}

	public void BackTeste()
	{

		SceneManager.LoadScene("Help");
	}

}

