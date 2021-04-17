using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject panel;
    public Text winText;
    public Text gameOverText;
    public Text highscoreText;
    public Button replay;
    public Button quit;


    // Update is called once per frame
    void Update()
    {
        if (InfoTracker.lives == 0)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
            gameOverText.enabled = true;
            winText.enabled = false;
            gameOverText.text = "Game Over! You ran out of lives. Your best score was " + InfoTracker.bestRoundScore + ".";
            highscoreText.text = "The highscore is " + InfoTracker.highscore + ".";
        }
        if (InfoTracker.score >= 42)
        {
            int totalScore = InfoTracker.score + (InfoTracker.lives * 20);
            if(totalScore > InfoTracker.highscore)
            {
                InfoTracker.highscore = totalScore;
            }
            panel.SetActive(true);
            Time.timeScale = 0;
            gameOverText.enabled = false;
            winText.enabled = true;
            winText.text = "Congratulations! You collected all of the points and prizes. You scored " + InfoTracker.score + " and had " + InfoTracker.lives + " lives remaining.\n For  each life remaining you also get 20 bonus points for a total score of " + totalScore + ".";
            highscoreText.text = "The highscore is " + InfoTracker.highscore + ".";
        }
    }

    public void Replay()
    {
        InfoTracker.score = 0;
        InfoTracker.lives = 3;
        InfoTracker.bestRoundScore = 0;
        Time.timeScale = 1f;
        panel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        if (UnityEditor.EditorApplication.isPlaying)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }
}
