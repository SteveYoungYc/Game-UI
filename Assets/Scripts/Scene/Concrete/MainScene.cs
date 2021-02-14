using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : SceneState
{
    private readonly string sceneName = "Main";
    private PanelManager panelManager;
    
    public override void OnEnter()
    {
        panelManager = new PanelManager();
        if (SceneManager.GetActiveScene().name != sceneName)
        {
            SceneManager.LoadScene(sceneName);
            SceneManager.sceneLoaded += SceneLoaded;
        }
        else
        {
            panelManager.Push(new MainPanel());
        }
    }

    public override void OnExit()
    {
        SceneManager.sceneLoaded -= SceneLoaded;
    }

    private void SceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
    {
        //panelManager.Push(new MainPanel());
        Debug.Log($"{sceneName}场景加载完毕");
    }
}
