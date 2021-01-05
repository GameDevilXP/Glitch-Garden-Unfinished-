using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] private GameObject defender;
    
    private void OnMouseDown() 
    {
        // Spawns the defender at the worldPos that GetSquareClicked() returns.
        SpawnDefender(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        // Gets the click pos from the screen, then converts it into the worldPos in-game.
        // Returns the worldPos
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPos;
    }

    private void SpawnDefender(Vector2 spawnPos) 
    {
        // Spawns the defender, the position is determined by the passed argument.
        GameObject newDefender = Instantiate(defender, spawnPos, Quaternion.identity) as GameObject;
    }
}
