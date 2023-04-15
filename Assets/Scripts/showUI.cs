using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{
    public GameObject uiCanvas;

    private void Start()
    {
        // Disable the UI canvas when the script starts
        uiCanvas.SetActive(false);
    }

    public void OnMarkerFound()
    {
        // Enable the UI canvas when the button is pressed
        uiCanvas.SetActive(true);
    }
    public void OnMarkerLost()
    {
        // Enable the UI canvas when the button is pressed
        uiCanvas.SetActive(false);
    }
}