using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    // The gun is the pos (also a child of Cactus) that the projectile will be instantiated.
    // Both the vars are serialized private gameObjects.
    [SerializeField] private GameObject projectile, gun;

    public void Fire()
    {
        // Instantiates the projectile.
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }    
}
