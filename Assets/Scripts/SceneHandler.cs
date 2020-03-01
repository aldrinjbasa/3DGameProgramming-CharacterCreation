using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SceneHandler : MonoBehaviour
{
    public void toCreateCharacterScene(string nameOfScene)
    {
        SceneManager.LoadScene(nameOfScene);
    }

    public void backFromCharacterCreation()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
