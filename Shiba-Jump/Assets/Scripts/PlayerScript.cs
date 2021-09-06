using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float runSpeed = 0.5f;
    float jumpSpeed = 1f;

    bool isCrouching = false;
    bool isJumping = false;

    Rigidbody2D rb;
    Animator animtor;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            isCrouching = true;
        else isCrouching = false;
    }

    private void FixedUpdate()
    {
        
    }
}
