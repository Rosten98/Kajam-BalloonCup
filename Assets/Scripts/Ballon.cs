using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
    private  Rigidbody2D rb_Ballon;
    private Vector3 respownPoint;
    // Start is called before the first frame update
    void Start()
    {
        rb_Ballon = GetComponent<Rigidbody2D>();
        respownPoint = rb_Ballon.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Respawn 
            Resets ballon position
            Temporaly Till score is set added 
        */
        if (Input.GetKey("r")) {
            rb_Ballon.transform.position = respownPoint;
        }
    }
}
