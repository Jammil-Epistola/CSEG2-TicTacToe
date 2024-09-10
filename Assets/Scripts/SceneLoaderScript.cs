using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderScript : MonoBehaviour
{
    // Start Screen Button
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    // Play Button at Main Menu
    // Shows Mode Select
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(2);
    }

    // Goes to 2 Player TicTacToe
    public void TwoPlayer()
    {
        SceneManager.LoadSceneAsync(3);
    }

    //Terminates the Program
    public void QuitGame()
    {
        Application.Quit();
    }

    // Returns to Main Menu
    public void BackToMainMenu()
    {
        SceneManager.LoadSceneAsync(1);
    }

}