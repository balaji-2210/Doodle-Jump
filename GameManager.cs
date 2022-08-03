using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject winGame;
    float maxScore;

    private void Awake()
    {
        Paused();
    }

    public void Play()
    {
        maxScore = 0;
        scoreText.text = "0 m";
        playButton.SetActive(false);
        gameOver.SetActive(false);
        winGame.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;
    }

    public void Paused()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Paused();
    }

    public void WinGame()
    {
        winGame.SetActive(true);
        playButton.SetActive(true);

        Paused();
    }


}
