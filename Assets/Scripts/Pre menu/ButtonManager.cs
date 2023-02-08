using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    Movement player;
    public GameObject poemScreen;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Movement>();
    }

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
        SceneManager.LoadScene(4);
    }

    public void OpenClue()
    {
        poemScreen.SetActive(true);
    }

    public void closePoem()
    {
        poemScreen.SetActive(false);
    }

    public void UnPause()
    {
        player.UnPause();
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
