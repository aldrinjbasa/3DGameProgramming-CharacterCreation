using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{

    void Update()
    {
        var checkCharacter = GameObject.Find("Player").GetComponent<Player>();
        if (checkCharacter.playActive == true) 
        {
            var startButton = transform.GetComponent<Button>();
            startButton.interactable = true;
        }
    }
}
