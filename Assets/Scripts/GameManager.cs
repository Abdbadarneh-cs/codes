using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("Abdallah", 80);
        Enemy enemy = new Enemy("Zarifeh", 100);

        Debug.Log("Player: " + player.Name + " Health: " + player.Health);
        Debug.Log("Enemy: " + enemy.Name + " Health: " + enemy.Health);

        player.Heal(15);
        enemy.Attack(player, 20);
    }
}

