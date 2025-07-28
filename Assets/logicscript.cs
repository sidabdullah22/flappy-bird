using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicscript : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("socrecard")]
    public void addScore(int scoreToadd)
    { 
        playerScore = playerScore + scoreToadd;
        scoreText.text=playerScore.ToString();
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