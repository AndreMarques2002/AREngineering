using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Options : MonoBehaviour {
    public void ExitButton() {
        Application.Quit();
        Debug.Log("App fechado");
    }

    public void StartApp() {
        SceneManager.LoadScene("AR");
    }

}