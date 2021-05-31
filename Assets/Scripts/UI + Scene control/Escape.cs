using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Escape : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))  
        {
            SceneManager.LoadScene("Exit");
        }

        if (SoulsEater.currentWolfCount == 0 && SoulsEater.currentRabbitCount == 0)
        {
            SceneManager.LoadScene("Exit");

        }
    }
}
