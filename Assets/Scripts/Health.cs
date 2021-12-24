using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public static int health = 3;
    public TextMeshProUGUI healthText;
    public GameObject endingPanel;
    void Update()
    {
        healthText.text = "Health : " + health.ToString();
        if(health == 0) 
        {
            endingPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
