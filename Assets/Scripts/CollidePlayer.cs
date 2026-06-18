using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DestroyPlayer : MonoBehaviour
{
    public GameObject player;
    public static int score = 0;
    public static int high_score = 0;
    AudioSource sound;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        sound = player.GetComponent<AudioSource>();
        rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("meteor"))
        {
            score = -1;
            rb.transform.position = new Vector3(0, -2, -1);
        }
        if (collision.CompareTag("coin"))
        {
            score+=1;
            Debug.Log(score);
            Destroy(collision.gameObject);
            sound.Play();
            if (score > high_score)
            {
                high_score = score;
            }
        }
    }
}
