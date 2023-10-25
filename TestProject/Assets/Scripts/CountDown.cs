using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    public string levelToLoad;
    private float timer = 10f;
    private TextMesh Timer;

    private void Start()
    {
        Timer = GetComponent<TextMesh>();
    }


    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Application.LoadLevel(levelToLoad);
        }
    }

}
