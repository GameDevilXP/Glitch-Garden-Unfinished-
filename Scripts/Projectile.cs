using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Creates a serialized private float and another one for damage.
    [Range(0.1f,10f)][SerializeField] private float speed = 1f;
    [SerializeField] private float damage = 50f;
    
    
    void Update()
    {
        // moves the transform position of the gameObject this script is attached to.
        // its moved right * the speed assigned * Time.deltaTime.
        // This way of doing it is inefficient but I don't know any other one for the same output.
        // Look for another one if you can, whenever you're back.
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        // When the projectile touches and gets triggered by the other collider
        // (in this case the enemy)
        // Gets the component for health and the attacker component
        // Can only get it if its an attacker but there isn't any if statement for it.
        // Other than the one below. I don't think any other one is needed for this.
        Health health = other.GetComponent<Health>();
        Attacker attacker = other.GetComponent<Attacker>();
        
        // Checks if both the attacker component and health component are present
        // if they are, call the deal damage method from health and 
        // destroy the game object this script is attached too
        if(attacker && health) 
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }   
    }
}

