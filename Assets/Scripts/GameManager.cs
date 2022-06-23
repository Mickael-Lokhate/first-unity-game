using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float restartDelay = 1f;
    bool gameEnd = false;

    public void GameOver() {
        if (!gameEnd) {
            gameEnd = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
