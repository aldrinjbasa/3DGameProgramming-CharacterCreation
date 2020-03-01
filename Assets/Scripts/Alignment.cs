using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alignment : MonoBehaviour
{
    public string[] alignmentList = { "Chaotic Evil",  "Neutral Evil", "Lawful Evil", "Chaotic Neutral", "Neutral", "Lawful Neutral", "Chaotic Good", "Neutral Good", "Lawful Good" };
    public Text alignmentSelect;
    public int listPointer = 4;

    private void Start()
    {
        alignmentSelect = transform.GetChild(3).GetComponent<Text>();
        alignmentSelect.text = alignmentList[4];
    }
    public void leftButton()
    {
        if (listPointer == 0)
        {
            listPointer = alignmentList.Length - 1;
            alignmentSelect = transform.GetChild(3).GetComponent<Text>();
            alignmentSelect.text = alignmentList[listPointer];
        }
        else if (listPointer != 0)
        {
            listPointer--;
            alignmentSelect = transform.GetChild(3).GetComponent<Text>();
            alignmentSelect.text = alignmentList[listPointer];
        }
    }
    public void rightButton()
    {
        if (listPointer == alignmentList.Length - 1)
        {
            listPointer = 0;
            alignmentSelect = transform.GetChild(3).GetComponent<Text>();
            alignmentSelect.text = alignmentList[listPointer];
        }
        else if (listPointer != alignmentList.Length - 1)
        {
            listPointer++;
            alignmentSelect = transform.GetChild(3).GetComponent<Text>();
            alignmentSelect.text = alignmentList[listPointer];
        }
    }
}
