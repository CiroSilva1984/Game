using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static float xSpeed = 1.5f;
    public static float jumpSpeed = 5.5f;
    //private static float movement = 0.0f;

    private Rigidbody2D rigidBody;
    private SpriteRenderer sprite;
    private new CapsuleCollider2D collider;
    private Animator playerAnimtr;

    public Transform groundCheckPoint;
    public float groundCheckPos;
    public LayerMask groundLayer;
    private bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<CapsuleCollider2D>();
        playerAnimtr = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //check if player is grounded        
        grounded = Physics2D.OverlapCapsule(collider.transform.position, collider.size, collider.direction, collider.transform.rotation.z, groundLayer);
        Debug.Log(grounded);
        Vector2 vel = new Vector2(0.0f, 0.0f);

        float curYspeed = rigidBody.velocity.y;
        float curXspeed = rigidBody.velocity.x;

        vel.x = xSpeed; 

        if(Input.GetButtonDown("Jump") & grounded)
        {
            //Debug.Log("jump pressed");                    
            vel.y = jumpSpeed;
        }
        else
        {
            vel.y = curYspeed;
        }

        rigidBody.velocity = vel;

        playerAnimtr.SetBool("onGround", grounded);
    }  
    
    void ChangeDirection()
    {
        xSpeed *= -1.0f;
        sprite.flipX = !sprite.flipX;
    }
}
