using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : PlayerController
{
    // Start is called before the first frame update
    void Start()
    {   
        rbPlayer = GetComponent<Rigidbody2D>();
        respownPoint = rbPlayer.transform.position;
        original_Size = rbPlayer.transform.localScale;
        jump_Button = "up";
        left_Button = "left";
        right_Button = "right";
    }

    // Update is called once per frame
    void Update()
    {
        Movement(); // From PlayerController Class for Lateral Movement and Jump
        /*Respawn
            Temporaly Till score is set added

            [Rescale]  is not fixed for respawn
        */
        if (Input.GetKey("r")) {
            rbPlayer.transform.position = respownPoint;
            speed = 20;
            //rbPlayer.transform.localScale = original_Size;
        }
    }
}
