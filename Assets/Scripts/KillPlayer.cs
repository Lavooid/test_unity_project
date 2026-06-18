using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class KillPlayer : MonoBehaviour
{
    AudioSource sound;
    public GameObject obj;
    
    // Start is called before the first frame update
    void Start()
    {
        sound = obj.GetComponentAtIndex<AudioSource>(6);
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyPlayer.score == -1)
        {     
            DestroyPlayer.score = 0;
            sound.Play();
            Invoke(nameof(LoadSceneF), 2f);
            Time.timeScale = 1f;
        }
        
    }

    void LoadSceneF()
    {
        SceneManager.LoadScene(0);
    }
}
