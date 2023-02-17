using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{
    public void StartLevelOne() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
    }

    public void StartLevelTwo() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level2");
    }

    public void StartLevelThree() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level3");
    }

    public void StartLevelFour() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level4");
    }

    public void StartMainMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
