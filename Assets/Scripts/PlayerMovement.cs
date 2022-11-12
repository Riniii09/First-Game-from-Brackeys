using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce=100f;
    public float SidewaysForce=100f;
    public float JumpHeight=10000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Yaha pe FixedUpdate isliye use kiya kyuki UNITY LIKES THAT WHEN WE ARE MESSING WITH UNITY 
    //PHYSICS ehehehheheehe thats it lol :P
    void FixedUpdate() 
    
    {
        //yeh time wala thoda jhol hai, baadme samjhungi
            rb.AddForce(0, 0, ForwardForce*Time.deltaTime);
            
        if(Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
