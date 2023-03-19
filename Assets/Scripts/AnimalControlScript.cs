using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class AnimalControlScript : MonoBehaviour
{
    private bool shouldShow;
    public GameObject popup;
    public TMP_Text text;
    public List<InputDevice> controllers;
    public List<string> descriptions;
    private int current = 0;

    // Start is called before the first frame update
    void Start()
    {
        popup.SetActive(false);
        controllers = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Controller, controllers);
        Debug.Log(controllers.Count);
        nextDescription();
    }

    public string getNextDescription()
    {
        if (current >= descriptions.Count) current = 0;
        string temp = descriptions.ElementAt(current);
        current++;
        return temp.Replace("nlz", Environment.NewLine);
    }

    public void nextDescription()
    {
        text.text = getNextDescription();
    }

    public void TogglePopup()
    {
        shouldShow = !shouldShow;
    }

// Update is called once per frame
    void Update()
    {
        popup.SetActive(shouldShow);
    }
}
