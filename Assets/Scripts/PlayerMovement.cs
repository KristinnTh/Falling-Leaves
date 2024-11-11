using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    // Update is called once per frame
    void Update()
    {
        //Get input for forward/backward movement
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //get input for left/right turning
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        
        //Move the player forward/backward
        transform.Translate(0,0, move);
        //rotate the player left/right
        transform.Rotate(0, turn, 0);
    }
}
