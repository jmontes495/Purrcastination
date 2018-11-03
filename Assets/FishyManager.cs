﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishyManager : MonoBehaviour
{
    public static FishyManager instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

    }

}
