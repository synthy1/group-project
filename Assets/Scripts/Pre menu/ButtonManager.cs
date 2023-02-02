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
    public void Credits()
    {
        //open credits scene
    }
    public void EndingOne()
    {
        //open ED1 scene
    }
    public void EndingTwo()
    {
        //open ED2 scene
    }

}
