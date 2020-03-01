using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratePlayer : MonoBehaviour
{
    // Start is called before the first frame update
   

    public void GeneratePlayerOnClick()
    {
        var retrieveName = transform.parent.GetChild(0).GetChild(2).GetComponent<Text>();
        var retrieveSTR = transform.parent.GetChild(1).GetChild(1).GetComponent<Text>();
        var retrieveDEX = transform.parent.GetChild(2).GetChild(1).GetComponent<Text>();
        var retrieveINT = transform.parent.GetChild(3).GetChild(1).GetComponent<Text>();
        var retrieveCON = transform.parent.GetChild(4).GetChild(1).GetComponent<Text>();
        var retrieveWIS = transform.parent.GetChild(5).GetChild(1).GetComponent<Text>();
        var retrieveCHA = transform.parent.GetChild(6).GetChild(1).GetComponent<Text>();
        var retrieveRACE = transform.parent.GetChild(7).GetChild(3).GetComponent<Text>();
        var retrieveCLASS = transform.parent.GetChild(8).GetChild(3).GetComponent<Text>();
        var retrieveALIGNMENT = transform.parent.GetChild(9).GetChild(3).GetComponent<Text>();
        string CharacterName = retrieveName.text;
        float Ability_Strength = float.Parse(retrieveSTR.text);
        float Ability_Dexterity = float.Parse(retrieveDEX.text);
        float Ability_Intelligence = float.Parse(retrieveINT.text);
        float Ability_Constitution = float.Parse(retrieveCON.text);
        float Ability_Wisdom = float.Parse(retrieveWIS.text);
        float Ability_Charisma = float.Parse(retrieveCHA.text);
        string Race = retrieveRACE.text;
        string CharacterClass = retrieveCLASS.text;
        string Alignment = retrieveALIGNMENT.text;

        //Player player = new Player(CharacterName, Ability_Strength, Ability_Dexterity, Ability_Intelligence, Ability_Constitution, Ability_Wisdom, Ability_Charisma, Race, CharacterClass, Alignment);
        Player player = transform.parent.GetChild(12).GetComponent<Player>();
        player.CharacterName = CharacterName;
        player.Ability_Strength = Ability_Strength;
        player.Ability_Dexterity = Ability_Dexterity;
        player.Ability_Intelligence = Ability_Intelligence;
        player.Ability_Constitution = Ability_Constitution;
        player.Ability_Wisdom = Ability_Wisdom;
        player.Ability_Charisma = Ability_Charisma;
        player.Race = Race;
        player.CharacterClass = CharacterClass;
        player.Alignment = Alignment;
        player.playActive = true;
        string jsonOutput = JsonUtility.ToJson(player);
        var output = transform.parent.parent.GetChild(3).GetComponent<InputField>();
        output.text = jsonOutput;
        player.transform.parent = null;
        Object.DontDestroyOnLoad(player);

    }

}
