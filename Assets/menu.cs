using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void ExitButton(){
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void NewGame(){
        SceneManager.LoadScene("game");
    }
}
