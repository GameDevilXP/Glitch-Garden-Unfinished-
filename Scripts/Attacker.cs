using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    // For now, this script doesn't do much. It has a lot of animations ready for it though.
    // Creates a serialized private float that determines the speed of the attacker.
    [Range(0f,5f)] [SerializeField] private float currentSpeed = 1f;

    void Update()
    {
        // Moves the attacker left * the speed variable * Time.deltaTime.
        // This way of doing it is inefficient but I don't know any other one for the same output.
        // Look for another one if you can, whenever you're back.
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime );
    }

    // Sets the movement speed, makes it the same as what the passed-in argument is.
    // Currently only used in the animations. Check the animations for more info.
    // (Lizard Walk and Lizard Jump).
    public void SetMovementSpeed(float speed) 
    {
        currentSpeed = speed;
    } 
}
