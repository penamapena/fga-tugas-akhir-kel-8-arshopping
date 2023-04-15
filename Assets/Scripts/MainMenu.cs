using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton(){
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void StartButton(){
        SceneManager.LoadScene("ARView");
    }

    public void InstructionButton(){
        SceneManager.LoadScene("Instruction");
    }

    public void AboutButton(){
        SceneManager.LoadScene("About");
    }
}
