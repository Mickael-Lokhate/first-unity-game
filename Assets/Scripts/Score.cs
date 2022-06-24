using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{

    public Transform    player;
    public Text         score;

    // Update is called once per frame
    void Update()
    {
        if (!FindObjectOfType<GameManager>().gameEnd)
        {
            score.text = player.position.z.ToString("0");
        }
    }
}
