using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    float maxScore = 0f;

    void Update()
    {
        if(player.position.y == 0f)
        {
            maxScore = 0f;
        }
        if(player.position.y > maxScore)
        {
            maxScore = player.position.y;
        }
        scoreText.text = maxScore.ToString("0") + " m";
    }
}
