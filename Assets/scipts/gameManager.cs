using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public bool isGameActive;
    
    public TextMeshProUGUI gameOverText;
    public Button restartButton; 
    

    private Timer Timer;
    
    public void Start ()
    {
        //vind de game objecten
        Timer = GameObject.Find("Text").GetComponent<Timer>();
        isGameActive = true;
    }
    
    // Stop game, bring up game over text and restart button
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
        Timer.Alive = false;
    }

    // Restart game by reloading the scene
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
            
}
