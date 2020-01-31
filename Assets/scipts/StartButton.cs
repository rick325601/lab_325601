using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    //variebele voor het script
    private Button button;
    private gameManager gameManager;
    private Timer timer;
    private SpawnManager spawnManager;
    private SpawnManager2 spawnManager2;
    private SpawnManager3 spawnManager3;
    private SpawnManager4 spawnManager4;
    
    public int Difficulty;
    
    // Start is called before the first frame update
    void Start()
    {
        //geeft een waarde en luisted naar de button
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        
        //find de Game manager/spawner en timer
        gameManager = GameObject.Find("Game Manager").GetComponent<gameManager>();
        timer = GameObject.Find("Text").GetComponent<Timer>();
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
        spawnManager2 = GameObject.Find("Spawn Manager 2").GetComponent<SpawnManager2>();
        spawnManager3 = GameObject.Find("Spawn Manager 3").GetComponent<SpawnManager3>();
        spawnManager4 = GameObject.Find("Spawn Manager 4").GetComponent<SpawnManager4>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //zet de difficulty
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name = " was clicked");
        gameManager.StartGame(Difficulty);
        timer.StartTimer();
        spawnManager.Startgame();
        spawnManager2.Startgame2();
        spawnManager3.Startgame3();
        spawnManager4.Startgame4();
    }
}
