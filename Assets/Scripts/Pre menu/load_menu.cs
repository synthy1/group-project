using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_menu : MonoBehaviour
{
    private void Start()
    {
        LoadMenu();
    }
    public float transitionTime;
    public void LoadMenu()
    {
        StartCoroutine(MenuLoad(SceneManager.GetActiveScene().buildIndex + 1));
    }


    IEnumerator MenuLoad(int levelIndex)
    {
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
