using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerScript : MonoBehaviour
{
    float runSpeed = 0.5f;
    float jumpSpeed = 1f;
    float jumpCharge = 0f;

    bool isCrouching = false;
    bool isJumping = false;
    bool isOnGround;

    Vector2 jumpPos = new Vector2(1,10);

    Rigidbody2D rb;
    Animator animtor;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButton("Jump"))
        { 
            isCrouching = true; 
        }
        else isCrouching = false;
    }

    private void FixedUpdate()
    {
        if (isCrouching) {
            jumpCharge += Time.fixedDeltaTime;
        }
        else if (jumpCharge > 0 && !isCrouching)
        {
            Jump(jumpCharge);
            jumpCharge = 0;
        }
    }

    void Jump(float jumpForce)
    {
        rb.AddForce(jumpPos*jumpForce, ForceMode2D.Impulse);
    }
}
