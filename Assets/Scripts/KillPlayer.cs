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
            
            sound.Play();
                        
            DestroyPlayer.score = 0;
        }
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
    }
}
