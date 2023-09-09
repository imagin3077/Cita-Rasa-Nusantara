using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Download()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1kJYBaCCXybRQ5VR6MFeB2LmD1MzrAkeO?usp=sharing");
    }

    public void QuitScene()
    {
        Application.Quit();
        Debug.Log("EXITTT!!!!");
    }
}
