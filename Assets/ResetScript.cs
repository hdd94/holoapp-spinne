﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoiceScript : MonoBehaviour {

	public void Reset () {
        Destroy(GameObject.Find("Informations"));
        Destroy(GameObject.Find("SpatialMapping"));
        SceneManager.LoadScene(0);
    }
}
