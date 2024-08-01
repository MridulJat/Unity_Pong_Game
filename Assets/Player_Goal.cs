using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player_Goal : MonoBehaviour
{
    [SerializeField] private bool Player_1_Goal;
    public static int Player_1_Score;
    public static int Player_2_Score;
    [SerializeField] private ball_movement ballMovementScript;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Text winnerText;

    private void Start()
    {
        gameOverPanel.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "ball")
        {
            if (Player_1_Goal)
            {
                Debug.Log("Player 1 Scored");
                Player_1_Score++;
                CheckForGameOver("Player 1");
            }
            else
            {
                Debug.Log("Player 2 Scored");
                Player_2_Score++;
                CheckForGameOver("Player 2");
            }
            ballMovementScript.ResetBall();
        }   
    }
    private void CheckForGameOver(string player)
    {
        if (Player_1_Score >= 10 || Player_2_Score >= 10)
        {
            winnerText.text = $"{player} Wins!";
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f; 
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        Player_1_Score = 0;
        Player_2_Score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
