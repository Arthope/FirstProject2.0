using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NextLevel()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(next);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
