﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToAirPlane : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadPlane() {
        SceneManager.LoadScene(1);
    }
}
