using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // This script makes the health for most enemies/defenders that will be having it.
    // Creates a serialized private float and GameObject. The float determines the health.
    // The GameObject is just for instantiating the particles when the enemy dies.
    [SerializeField] private float health = 100f;
    [SerializeField] private GameObject deathVFX;
    
    // Deals the damage when called, for now, only called by the Projectile.
    public void DealDamage(float damage)
    {
        // reduces the health with the argument passed in.
        health -= damage;

        // In case the health is above 0 or 0, Trigger the death VFX and destroy this game object.
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    // Triggers the death VFX.
    private void TriggerDeathVFX()
    {
        // In the case that there is no death VFX, have a countermeasure or announce it.
        if (!deathVFX)
        {
            Debug.Log("There is no death VFX");
        }
        // Instantiates the Death VFX and destroys it 2 seconds later.
        GameObject deathVFXObject = Instantiate(deathVFX,transform.position,Quaternion.identity);
        Destroy(deathVFXObject, 2f);
    }

}
