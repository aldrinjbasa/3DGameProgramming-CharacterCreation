using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Class : MonoBehaviour
{
    public string[] classList = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
    public Text classSelect;
    public int listPointer = 0;

    private void Start()
    {
        classSelect = transform.GetChild(3).GetComponent<Text>();
        classSelect.text = classList[0];
    }
    public void leftButton()
    {
        if(listPointer == 0)
        {
            listPointer = classList.Length - 1;
            classSelect = transform.GetChild(3).GetComponent<Text>();
            classSelect.text = classList[listPointer];
        }
        else if (listPointer != 0)
        {
            listPointer--;
            classSelect = transform.GetChild(3).GetComponent<Text>();
            classSelect.text = classList[listPointer];
        }
    }
    public void rightButton()
    {
        if(listPointer == classList.Length - 1)
        {
            listPointer = 0;
            classSelect = transform.GetChild(3).GetComponent<Text>();
            classSelect.text = classList[listPointer];
        }
        else if (listPointer != classList.Length - 1)
        {
            listPointer++;
            classSelect = transform.GetChild(3).GetComponent<Text>();
            classSelect.text = classList[listPointer];
        }
    }
}
