using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    } 

    public void startScene()
    {
        SceneManager.LoadScene("7");
    }
}
