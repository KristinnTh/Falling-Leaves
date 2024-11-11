using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; //Reference to the player
    public Vector3 offset; //Initial offset between the camera and the player

     // LateUpdate is called once per frame, after all Update functions have been called
    // This is especially useful for camera movement to ensure that it updates after the player's movement, preventing jitter.
    void LateUpdate()
    {
        // Sets the camera's position by adding the offset to the player's position.
        // This keeps the camera at a fixed distance from the player, creating a "following" effect.
        transform.position = player.position + offset;
        // Rotates the camera to look directly at the player's position.
        // Ensures the camera is always oriented toward the player, maintaining focus on them.
        transform.LookAt(player);
    }
}
