using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int timeLeft = 0;
    public Text countdown;
    private gameManager GameManager;

    public int index;
    public string levelName;
    
    void Start()
    {
        //find de Game manager
        GameManager = GameObject.Find("Game Manager").GetComponent<gameManager>();
    }

    public void StartTimer()
    {
        StartCoroutine(GainTime());
        Time.timeScale = 1;
    }
    void Update () 
    {
        countdown.text = ("time: " + timeLeft);
        
        if (timeLeft > 45)
        {
            //laad level met build uit de index 
            SceneManager.LoadScene(index);
            
            //laad level met scene name
            SceneManager.LoadScene(levelName);
        }
    }
    
    //Simple Coroutine
    public IEnumerator GainTime()
    {
        while (true)
        {
            yield return new WaitForSeconds (1);
            timeLeft++; 
        }
    }
}
