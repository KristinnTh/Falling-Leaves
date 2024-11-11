using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collectable : MonoBehaviour
{
    // A static event triggered when a collectable item is collected.
    // Other scripts can subscribe to this event to respond when an item is collected.
    public static event Action OnCollected;
    // A static integer to track the total number of collectable items created.
    // Static means this value is shared across all instances of the Collectable class.
    public static int total;


    // Awake is called when the script instance is being loaded.
    // Increments the total number of collectable items each time a new one is created.
    void Awake() => total++;

// OnTriggerEnter is called when another collider enters the trigger collider attached to this GameObject.
    // Used to detect when the player interacts with the collectable item.
    void OnTriggerEnter(Collider other)
    {
        // Checks if the other object has the tag "Player" to ensure only the player can collect the item.
        if(other.CompareTag("Player"))
        {
            // If a subscriber exists for the OnCollected event, invokes the event.
            // The null-conditional operator (?.) ensures no errors if no listeners are attached.
            OnCollected?.Invoke();
            // Destroys the collectable item (this GameObject) from the scene, simulating the collection.
            Destroy(gameObject);
        }
    }
}
