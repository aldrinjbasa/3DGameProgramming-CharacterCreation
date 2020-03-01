using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //Class Variables
    public string characterName;
    public float ability_Strength;
    public float ability_Dexterity;
    public float ability_Intelligence;
    public float ability_Constitution;
    public float ability_Wisdom;
    public float ability_Charisma;
    public string race;
    public string characterClass;
    public string alignment;
    public int currentXP;
    public int levelupXP;
    public int currentHP;
    public int maxHP;
    public int ability_Armor;
    public int walkSpeed;
    public int runSpeed;
    public int jumpHeight;
    public List<string> inventory = new List<string>();
    public bool playActive = false;

    //Get and Set Methods
    public string CharacterName { get => characterName; set => characterName = value; }
    public float Ability_Strength { get => ability_Strength; set => ability_Strength = value; }
    public float Ability_Dexterity { get => ability_Dexterity; set => ability_Dexterity = value; }
    public float Ability_Intelligence { get => ability_Intelligence; set => ability_Intelligence = value; }
    public float Ability_Constitution { get => ability_Constitution; set => ability_Constitution = value; }
    public float Ability_Wisdom { get => ability_Wisdom; set => ability_Wisdom = value; }
    public float Ability_Charisma { get => ability_Charisma; set => ability_Charisma = value; }
    public string Race { get => race; set => race = value; }
    public string CharacterClass { get => characterClass; set => characterClass = value; }
    public string Alignment { get => alignment; set => alignment = value; }
    public int CurrentXP { get => currentXP; set => currentXP = value; }
    public int LevelupXP { get => levelupXP; set => levelupXP = value; }
    public int CurrentHP { get => currentHP; set => currentHP = value; }
    public int MaxHP { get => maxHP; set => maxHP = value; }
    public int Ability_Armor { get => ability_Armor; set => ability_Armor = value; }
    public int WalkSpeed { get => walkSpeed; set => walkSpeed = value; }
    public int RunSpeed { get => runSpeed; set => runSpeed = value; }
    public int JumpHeight { get => jumpHeight; set => jumpHeight = value; }

    /*private void Awake()
    {
        Object.DontDestroyOnLoad(transform.gameObject);
    }*/


    public Player()
    {
        CharacterName = "No Name";
        Ability_Strength = 10;
        Ability_Dexterity = 10;
        Ability_Intelligence = 10;
        Ability_Constitution = 10;
        Ability_Wisdom = 10;
        Ability_Charisma = 10;
        Race = "Human";
        CharacterClass = "Warrior";
        Alignment = "Neutral";
        CurrentXP = 0;
        LevelupXP = 10;
        CurrentHP = 10;
        MaxHP = 10;
        Ability_Armor = 1;
        WalkSpeed = 16;
        RunSpeed = 25;
        JumpHeight = 5;
        //inventory.Add("Sword");
    }

    public Player(string name, float str, float dex, float intelligence, float con, float wis, float cha, string charRace, string charClass, string charAlign)
    {
        CharacterName = name;
        Ability_Strength = str;
        Ability_Dexterity = dex;
        Ability_Intelligence = intelligence;
        Ability_Constitution = con;
        Ability_Wisdom = wis;
        Ability_Charisma = con;
        Race = charRace;
        CharacterClass = charClass;
        Alignment = charAlign;
        CurrentXP = 0;
        LevelupXP = 10;
        CurrentHP = 10;
        MaxHP = 10;
        Ability_Armor = 1;
        WalkSpeed = 16;
        RunSpeed = 25;
        JumpHeight = 5;
        //inventory.Add("Sword");
    }

}
