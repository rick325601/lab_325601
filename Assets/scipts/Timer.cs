using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Timer : MonoBehaviour
{
    public int timeLeft = 0;
    public Text countdown;
    public bool Alive;
    
    void Start()
    {
        StartCoroutine(GainTime());
        Time.timeScale = 1;
        Alive = true;
    } 
    
    void Update () 
    {
        if (Alive)
        {
            countdown.text = ("time: " + timeLeft);
        }
    }
    
    //Simple Coroutine
    IEnumerator GainTime()
    {
        while (true) {
            yield return new WaitForSeconds (1);
            timeLeft++; 
        }
    }
}
