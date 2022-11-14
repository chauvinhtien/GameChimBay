using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Tăng Điểm
    [SerializeField] private Text scoreText;
    private int score = 0;
    
    //UI
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject getReady;


    //Lay con chim de reset nó
    [SerializeField] PlayerController player;
    private void Awake() {
        Application.targetFrameRate = 60;
        GetReady();
    }
    // Tăng Điểm
    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
    public void GetReady()
    {
        Time.timeScale = 0;
        playButton.SetActive(true);
        gameOver.SetActive(false);
        getReady.SetActive(true);
    }
    public void Pause()
    {
        Time.timeScale = 0f;
    }
    public void Play()
    {
        player.transform.position = new Vector3(0,0,0);
        score = 0;
        scoreText.text = score.ToString();
        playButton.SetActive(false);
        gameOver.SetActive(false);
        getReady.SetActive(false);
        Time.timeScale = 1;

        ObstacleMove[] pipes = FindObjectsOfType<ObstacleMove>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }
}
