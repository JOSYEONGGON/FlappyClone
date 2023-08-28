using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower = 3;
    public AudioClip[] intro_music;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            GetComponent<AudioSource>().clip = intro_music[0];
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // (0,3) ¼Óµµ YÁÂÇ¥¸¦ ¼öÁ¤ÇØ ¶ç¿ì´Â ´À³¦À» ÁØ´Ù. 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }

        SceneManager.LoadScene("GameOverScene");
    }
}
