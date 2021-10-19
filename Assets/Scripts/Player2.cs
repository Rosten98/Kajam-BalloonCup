using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : PlayerController
{
    // Start is called before the first frame update
    void Start()
    {   
        rbPlayer = GetComponent<Rigidbody2D>();

        jump_Button = "up";
        left_Button = "left";
        right_Button = "right";
    }

    // Update is called once per frame
    void Update()
    {
        Movement(); // From PlayerController Class for Lateral Movement and Jump

    }
}
