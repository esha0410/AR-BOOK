using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenCam : MonoBehaviour
{
    public void LoadCamScene()
    {
        SceneManager.LoadScene("ARbook");
    }

    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("you have quit the app");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
