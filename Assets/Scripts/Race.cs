using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Race : MonoBehaviour
{
    public string[] raceList = { "Dragonborn", "Dwarf", "Elf", "Gnome", "Half-Elf", "Half-Orc", "Halfling", "Human", "Tiefling" };
    public Text raceSelect;
    public int listPointer = 0;

    private void Start()
    {
        raceSelect = transform.GetChild(3).GetComponent<Text>();
        raceSelect.text = raceList[0];
    }
    public void leftButton()
    {
        if (listPointer == 0)
        {
            listPointer = raceList.Length - 1;
            raceSelect = transform.GetChild(3).GetComponent<Text>();
            raceSelect.text = raceList[listPointer];
        }
        else if (listPointer != 0)
        {
            listPointer--;
            raceSelect = transform.GetChild(3).GetComponent<Text>();
            raceSelect.text = raceList[listPointer];
        }
    }
    public void rightButton()
    {
        if (listPointer == raceList.Length - 1)
        {
            listPointer = 0;
            raceSelect = transform.GetChild(3).GetComponent<Text>();
            raceSelect.text = raceList[listPointer];
        }
        else if (listPointer != raceList.Length - 1)
        {
            listPointer++;
            raceSelect = transform.GetChild(3).GetComponent<Text>();
            raceSelect.text = raceList[listPointer];
        }
    }
}
