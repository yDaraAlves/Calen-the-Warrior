using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liberarpulo : MonoBehaviour
{
    public bool isJumping;

    public float JumpForce;

    private Rigidbody2D rig;

    
   

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        Jump();

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
           rig.AddForce(new Vector2(0f,JumpForce),ForceMode2D.Impulse);
            
        }

    }



   
}
