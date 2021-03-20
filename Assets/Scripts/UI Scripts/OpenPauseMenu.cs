using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;

public class OpenPauseMenu : MonoBehaviour
{
    public GameObject panelPauseGame;
    private bool flagControlPanel;

    void Awake()
    {
        flagControlPanel = false;   
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))           
            panelPauseGame.SetActive(true);     
    }


}
