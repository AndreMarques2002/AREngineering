using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class Resposta : MonoBehaviour {

    public GameObject username;
    public GameObject course;
    public GameObject feedback;
    public GameObject errors;


    private string Name;
    private string CourseGrad;
    private string FeedbackUser;
    private string Error;

    [SerializeField]

    private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSf8lZlpVvlDdnZvMAMCRiSrnvIwXwBJdd3q3AZX-RMx17HgeA/formResponse";


    
    IEnumerator Post(string name, string curso, string avaliacao, string erro) {
        WWWForm form = new WWWForm();
        form.AddField("entry.1509148641", name);
        form.AddField("entry.1818682740", curso);
        form.AddField("entry.295373756", avaliacao);
        form.AddField("entry.2139485664", erro);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;
    }

    public void Send() {
        Name = username.GetComponent<InputField>().text;
        CourseGrad = course.GetComponent<InputField>().text;
        FeedbackUser = feedback.GetComponent<InputField>().text;
        Error = errors.GetComponent<InputField>().text;

        StartCoroutine(Post(Name, CourseGrad, FeedbackUser, Error));
    }
}