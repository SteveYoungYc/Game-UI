using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    private PanelManager panelManager;
    // Start is called before the first frame update
    void Awake()
    {
        panelManager = new PanelManager();
    }

    private void Start()
    {
        panelManager.Push(new StartPanel());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
