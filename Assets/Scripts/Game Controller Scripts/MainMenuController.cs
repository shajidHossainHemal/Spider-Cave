﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame() {
        GameManager.instance.GoToLevelMenuScene();
    }

    public void QuitGame() {
        Application.Quit();
    }
}
