using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Handicaps : MonoBehaviour
{
    private static int score;
    public TextMeshProUGUI scoretext, endingtitle;

    private void Start()
    {
        score = 0;
    }
    private void Update()
    {
        scoretext.text = "Score : " + score.ToString();
        endingtitle.text = "Game Over \n Score : " + score.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        float xPosition = Random.Range(-7f, 7f);
        float yPosition = Random.Range(6.5f, 15f);
        if (collision.gameObject.tag == "ControlBlock")
        {
            transform.position = new Vector2(xPosition, yPosition);
            score += Random.Range(7, 10);
        }
        else if (collision.gameObject.tag == "Character")
        {
            transform.position = new Vector2(xPosition, yPosition);
            Health.health--;
        }
    }
 
}
