//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Roll : MonoBehaviour
{
    public int[] rolls = new int[6];
    public int[] statRolls;
    public int number;
    public Text changeStat;
    //public Boolean activateCreate;
    void Start() 
    {
        //for(int i=0; i<=5; i++)
        //{
        //    rolls[i] = 0;
        //    number = 0;
        //}
    }

    public void generateNumber()
    {
        //Roll all 6 stats at once
        for (int x = 1; x <= 6; x++)
        {

            //Roll 6 times and store in an array
            for (int i = 0; i <= 5; i++)
            {
                number = Random.Range(1, 7);
                rolls[i] = number;
            }

            //Sort Array (Insertion Sort)
            int n = rolls.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = rolls[i];
                int j = i - 1;
                while (j >= 0 && rolls[j] > key)
                {
                    rolls[j + 1] = rolls[j];
                    j--;
                }
                rolls[j + 1] = key;
            }

            //Changes the stat
            int statModifier = 2;
            number = rolls[3] + rolls[4] + rolls[5] + statModifier;
            changeStat = transform.parent.GetChild(x).GetChild(1).GetComponentInChildren<Text>();
            changeStat.text = "" + number;
        }
        
    }
   
}
