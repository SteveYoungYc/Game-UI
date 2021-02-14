using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoot : MonoBehaviour
{
    public static GameRoot Instance { get; private set; }
    public SceneSystem SceneSystem { get; private set; }

    private void Awake()
    {
        Instance = this;
        SceneSystem = new SceneSystem();
    }

    private void Start()
    {
        SceneSystem.SetScene(new StartScene());
    }
}
