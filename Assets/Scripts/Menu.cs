using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Menu : MonoBehaviour
{
    // Starts game when user clicks on start button
    public void OnStartButton() {
        SceneManager.LoadScene(1);
    }

    // Exits game when user clicks on exit button 
    public void OnExitButton() {
        Application.Quit();
    }

    // Returns to start menu when user clicks in-game menu button
    public void OnMenuButton() {
        SceneManager.LoadScene(0);
    }
}
