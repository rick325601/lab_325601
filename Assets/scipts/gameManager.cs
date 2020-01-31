using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public Button restartButton; 
    public GameObject titlescreen;
    public TextMeshProUGUI WinText;
    public bool IsGameActive;
    
    public void Start ()
    {
     
    }
    
    // Stop game, bring up game over text and restart button
    public void GameOver()
    {       
        //stopt de game geeft de gameover text en de restart knop
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        IsGameActive = false;
    }

    public void Gamewin()
    {
        WinText.gameObject.SetActive(true);
    }

    // Restart game by reloading the scene
    public void RestartGame()
    {
        //herlaad de scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame(int difficulty)
    {
        //maakt de game active en zet de difficulty
        IsGameActive = true;

        //haald het titel scherm weg
        titlescreen.gameObject.SetActive(false);
        
    }
}
