using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        //scoreText = player.position.z - ((player.position.z * 100000) % 100000);
    }
}
