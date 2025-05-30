using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicManagerScript : MonoBehaviour
{
    public int playScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    [ContextMenu("increase score")]
    public void addScore(int scoreToAdd)
    {
        playScore += scoreToAdd;
        scoreText.text = playScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
