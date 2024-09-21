using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This script pauses and plays the game
*/
public class PauseButton : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && Time.timeScale != 0)
        {
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
}
