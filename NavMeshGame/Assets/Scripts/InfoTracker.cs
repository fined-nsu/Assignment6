using UnityEngine;
using UnityEngine.UI;

public class InfoTracker : MonoBehaviour
{
    public Text scoreText;
    public Text livesText;
    public static int lives = 3;
    public static int score = 0;
    public static int bestRoundScore;
    public static int highscore = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
        if (score > highscore)
        {
            highscore = score;
        }
    }
}