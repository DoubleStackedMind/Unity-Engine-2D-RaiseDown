using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EarnMoney : MonoBehaviour
{

    private Text ScoreText;
    // Use this for initialization
    void Start()
    {
        ScoreText = GameManager.gm.GameplayUI.Find("CoinsRedeemed").Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Handle")
        {
            Destroy(gameObject);
            ScoreText.text = Convert.ToString(Int32.Parse(ScoreText.text) + 10);
        }
    }

}
