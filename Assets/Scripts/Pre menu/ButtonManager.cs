using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GameExit()
    {
        Application.Quit();
    }
    public void Options()
    {
        //oppen up second ui hidden at start with options on it
    }
    public void credits()
    {
        //open credits scene
    }

}
