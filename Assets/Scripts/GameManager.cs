using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float restartDelay = 1f;
    public bool gameEnd = false;
    public GameObject completeLevelUI;

    public void GameOver() {
        if (!gameEnd) {
            gameEnd = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
        gameEnd = true;
    }
}
