﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadNextLevel : MonoBehaviour
{
    public int SceneToLoad;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        //other.name should equal the root of your Player object
        if (other.name == "Player")
        {
            //The scene number to load (in File->Build Settings)
            if (GameObject.Find("AudioManager") != null)
            {
                AudioManager.instance.Play("NewLevel");
            }
            SceneManager.LoadScene(0);
        }

    }
}
