using UnityEngine;
using System.Collections;

public class youtubeLinhas : MonoBehaviour
{

    public void Openyoutube()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=ROWleHblyTM");
    }

    public void OpenURL(string link)
    {
        Application.OpenURL(link);
    }
}
