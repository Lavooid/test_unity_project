using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OtherThings : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 0f)
            {
                Time.timeScale = 1f;
            }
        }

        text.text = DestroyPlayer.score.ToString();
    }
}
