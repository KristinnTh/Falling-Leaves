using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCount : MonoBehaviour
{
    //reference to text component
    TMPro.TMP_Text text;
    //Integer to keep track of the number of items collected
    int count;


    // Awake is called when the script instance is loaded.
    // Here, it initializes the text reference by getting the TMP_Text component attached to this GameObject.
    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }
    // Start is called before the first frame update.
    // Calls UpdateCount() to initialize the text display with the starting values.
    void Start() => UpdateCount();
    // OnEnable is called when the object becomes enabled and active.
    // Subscribes the OnCollectibleCollected method to the Collectable.OnCollected event.
    void OnEnable() => Collectable.OnCollected += OnCollectibleCollected;
    // OnDisable is called when the object becomes disabled or inactive.
    // Unsubscribes the OnCollectibleCollected method from the Collectable.OnCollected event to prevent memory leaks.
    void OnDisable() => Collectable.OnCollected -= OnCollectibleCollected;
    // Method called when a Collectable item is collected.
    // Increments the count and updates the displayed count text.
    void OnCollectibleCollected()
    {
        count++;// Increments the number of items collected.
        UpdateCount(); //Updates the text display with the new count.
    }
    // Updates the displayed count text to show the number of collected items and the total number of Collectables.
    void UpdateCount()
    {
        // Sets the text to show the current count and the total number of collectibles in the format "collected / total".
        text.text = $"{count} / {Collectable.total}";
    }
}
