using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class deathCount : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public int playerFalls = 0;
    private bool alive;
    // Update is called once per frame
    void Update()
    {
        if (player.position.y < -9 && alive)
        {
            playerFalls += 1;
            scoreText.text = "Deaths :" + playerFalls.ToString();
            alive = false;
        }

        if(!alive && player.position.y > -5)
        {
            alive = true;
        }

    }
}
