using UnityEngine;
using System.Collections;

public class youtube : MonoBehaviour
{

    public void Openyoutube()
    {
        Application.OpenURL("https://youtu.be/DI8AJYT9VDI");
    }

    public void OpenURL(string link)
    {
        Application.OpenURL(link);
    }
}