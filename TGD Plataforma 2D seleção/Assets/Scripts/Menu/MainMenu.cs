using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //selects the level01
    public void PlayGame()
    {

        SceneManager.LoadScene("Scenes/Level01");

    }


    //quits the game
    public void QuitGame()
    {

        Debug.Log("QUIT!");
        Application.Quit();

    }
}
