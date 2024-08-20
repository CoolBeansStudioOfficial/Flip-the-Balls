using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    public GameObject ballRed;
    public GameObject ballBlue;

    public GameObject player;
    public GameObject startButton;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;

    int score = 0;
    int time;

    public void StartGame()
    {
        score = 0;
        time = 30;

        StartTimer();
    }

    void EndGame()
    {
        startButton.SetActive(true);
        player.SetActive(false);
        timeText.SetText("");
    }

    void StartTimer()
    {
        if (time > 0)
        {
            Invoke("UpdateTime", 1f);
        }
        else
        {
            EndGame();
        }
    }

    void UpdateTime()
    {
        time--;
        if (time > 9)
        {
            timeText.SetText("0:" + time.ToString());
        }
        else
        {
            timeText.SetText("0:0" + time.ToString());
        }

        StartTimer();
        SpawnBall();

    }

    public void UpdateScore(int points)
    {
        score = score + points;
        scoreText.SetText("Score: " + score.ToString());
    }

    void SpawnBall()
    {
        int ballSelect = Random.Range(0, 2);

        if (ballSelect == 0)
        {
            Instantiate(ballRed, new Vector3(Random.Range(-2, 3), 8, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(ballBlue, new Vector3(Random.Range(-2, 3), 8, 0), Quaternion.identity);
        }
    }
}