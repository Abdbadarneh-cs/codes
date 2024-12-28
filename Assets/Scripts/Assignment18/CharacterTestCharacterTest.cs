using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment18;

public class CharacterTest : MonoBehaviour
{
    private void Start()
    {
        Character[] characters = new Character[2];
        characters[0] = new Soldier(); 
        characters[1] = new Officer("Abdallah", 90, new Position(10, 5, 0)); 

        
        foreach (var character in characters)
        {
            character.DisplayInfo();
        }

        
        Officer officer = characters[1] as Officer;
        Soldier soldier = characters[0] as Soldier;

        if (officer != null && soldier != null)
        {
            Debug.Log($"Soldier's Health before attack: {soldier.Health}");
            officer.Attack(20, soldier, "shooting");
            Debug.Log($"Soldier's Health after attack: {soldier.Health}");
        }
    }
}
