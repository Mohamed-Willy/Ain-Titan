using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void gloader(string path)
    {
        SceneManager.LoadScene(path);
    }
    public void gexit()
    {
        Application.Quit();
    }
}
