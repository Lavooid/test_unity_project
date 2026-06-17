using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DestroyPlayer : MonoBehaviour
{
    public GameObject player;
    public int score =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("meteor"))
        {
            Destroy(player);
        }
        if (collision.CompareTag("coin"))
        {
            score+=1;
            Debug.Log(score);
            Destroy(collision.gameObject);
        }
    }
}
