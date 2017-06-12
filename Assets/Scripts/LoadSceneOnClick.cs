﻿using UnityEngine;
using UnityEngine.SceneManagement;

/**
* This script loads the next scene on click 
* 
* @author: Huy Duc Do
* 
**/
public class LoadSceneOnClick : MonoBehaviour
{
    /// <summary>
    /// Used to load the scene by given index number
    /// </summary>
    /// <param name="sceneIndex"></param> index number of a scene
	public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
