using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    // This script is for spawning attackers.
    // Creates 4 vars here, one for telling us which Attacker to instantiate.
    // the 2 floats for min and max of the Random.Range used in Start.
    // A bool for spawning the Attackers when its true.
    [SerializeField] Attacker attackerPrefab;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    bool spawn = true;

   
    // Turns the start function into a coroutine.
    IEnumerator Start()
    {
        // While spawn is true, wait for a random number of seconds and then spawn the attacker.
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    // Spawns the attacker at the transform.position of the gameObject that
    // this script is attached too.
    private void SpawnAttacker() 
    {
        Instantiate(attackerPrefab, transform.position, Quaternion.identity);
    }
}
