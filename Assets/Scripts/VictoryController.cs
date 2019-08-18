using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryController : MonoBehaviour {
    
    public void OnReplayButtonClick() {

        SceneManager.LoadScene("Game");

    }

    public void OnQuitButtonClick() {

        Application.Quit();

    }

}
