using UnityEngine;
using System.Collections;

public class Hyperlinks : MonoBehaviour {
   
    public void OpenForms() {
        Application.OpenURL("https://forms.gle/3w3RAoieBcKhSZGSA");   
    }

    public void OpenURL(string link) {
        Application.OpenURL(link);
    }
}
