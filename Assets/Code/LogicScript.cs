using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    private int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public PipeSpawnerScript pipeSpawner;

    void Start()
    {
        pipeSpawner = GameObject.FindGameObjectWithTag("PipeSpawner").GetComponent<PipeSpawnerScript>();
    }

    [ContextMenu("addScore")]
    public void addScore(int scoreToAdd)
    {
        playerScore+= scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    [ContextMenu("addDifficulty")]
    public void addDifficulty()
    {
        if (playerScore % 10 == 0)
        {
            pipeSpawner.spawnRate -= 0.1f;
        }
    }
}
