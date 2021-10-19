using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private  int speed = 10;
    [SerializeField] private  float jumpHeight = 200f;
    [SerializeField] private  float NumberJumps = 0f;
    [SerializeField] private  float MaxJumps = 2;

    protected  Rigidbody2D rbPlayer;
    protected string jump_Button = "w";
    protected string left_Button = "a";
    protected string right_Button = "d";

    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
    }

    //Lateral Movement  and Jump
    protected void Movement()
    {
        Vector3 pos = transform.position;

        //Move Right
         if (Input.GetKey(right_Button)) {
             pos.x += speed * Time.deltaTime;
         }

         //Move Left
         if (Input.GetKey(left_Button)) {
             pos.x -= speed * Time.deltaTime;
         }

        //Intend to add a doble or triple jump
        if (NumberJumps > MaxJumps - 1){
            isGrounded = false;
        }

        //Accion Jump
        if (Input.GetKey (jump_Button)  && isGrounded){
            rbPlayer.AddForce(Vector3.up * jumpHeight);
            NumberJumps += 1;
        }

         transform.position = pos;
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        isGrounded = true;
        NumberJumps = 0;
    }
}
