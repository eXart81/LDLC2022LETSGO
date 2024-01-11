using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textTMP : MonoBehaviour
{
    [SerializeField]
    TMP_Text healthText;
    [SerializeField]
    TMP_Text scoreText;

    public void UpdateDeuxText (int healthValue, int scoreValue)
    {
        healthText.text = "Points de vie : " + healthValue.ToString();
        scoreText.text = "score : " + scoreValue.ToString();
    }
    private void Update()
    {
        UpdateDeuxText(100,50);
    }
}
