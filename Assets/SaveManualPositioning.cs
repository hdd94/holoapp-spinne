﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManualPositioning : MonoBehaviour {

    public void Save()
    {
        //GameObject.Find("btnConform").GetComponent<SaveInformations>().developerMode = GameObject.Find("DeveloperMode").GetComponent<Toggle>().isOn;
        GameObject.Find("Informations").GetComponent<SaveInformations>().manualPositioning = GameObject.Find("ManualPositioning").GetComponent<Toggle>().isOn;
    }
}
