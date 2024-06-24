using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    [Header("---Game State---")]
    public GameState gamestate;
    public EnemyManager enemymanager;

    [Header("---Game Difficulty---")]
    public int scoreMultiplyer = 1;
    public GameDifficulty gameDifficulty = GameDifficulty.easy;

    private void Start()
    {
        StartGame();
        Difficulty();
    }
    void Update()
    {
        if (gamestate == GameState.Start)
            StartGame();
        else if (gamestate == GameState.Playing)
            PlayGame();
        else if (gamestate == GameState.Paused)
            PauseGame();
        else if (gamestate == GameState.Win)
            WinGame();
        else if (gamestate == GameState.Lose)
            LoseGame();

        if (gameDifficulty == GameDifficulty.easy)
            Easy();
        else if(gameDifficulty == GameDifficulty.medium)
            Medium();
        else if(gameDifficulty == GameDifficulty.hard)
            Hard();

    }

    void Difficulty()
    {
        switch (gameDifficulty)
        {
            case GameDifficulty.easy:
                scoreMultiplyer = 1;
                break;
            case GameDifficulty.medium:
                scoreMultiplyer = 2;
                break;
            case GameDifficulty.hard:
                scoreMultiplyer = 4;
                break;
        }
    }
    void StartGame()
    {
        //enemymanager.SpawnEnemies();
        gamestate = GameState.Playing;
    }

    void PlayGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gamestate = GameState.Paused;
        }
    }

    void PauseGame()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            gamestate = GameState.Playing;
        }
    }

    void WinGame()
    {

    }

    void LoseGame()
    {

    }

    void Easy()
    {

    }

    void Medium()
    {

    }

    void Hard()
    {

    }
}
