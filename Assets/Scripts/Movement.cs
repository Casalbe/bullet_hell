using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    [SerializeField] private float speed;
    private float defaultSpeed;
    [SerializeField] private float jumpingPower = 16f;
    private bool isFacingRight = true;
    bool isGrounded = false;

    bool isCrouching = false;

    [SerializeField] private Collider2D isGroundedCollider;
    [SerializeField] private Collider2D enemyCollider;
    [SerializeField] Animator animator;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    public int DeathScene;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown("up") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            isGrounded = false;
            animator.SetBool("isJumping", !isGrounded);
        }

        if (Input.GetKeyUp("up") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        if (Input.GetKeyDown("down") && isGrounded){
            isGrounded = false;
            defaultSpeed = speed;
            speed = 0;
            if (isCrouching == false){
                animator.SetBool("isCrouching", true);
            }
            isCrouching = true;
            
        } else if (Input.GetKeyUp("down")){
            isCrouching = false;
            isGrounded = true;
            speed = defaultSpeed;
            animator.SetBool("isCrouching", false);
            
        }

        


        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        animator.SetFloat("xVelocity", Math.Abs(rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Floor")){
            isGrounded = true;
            animator.SetBool("isJumping", false);
        } else if(collider.CompareTag("Bullet")){
            SceneManager.LoadSceneAsync("DeathScene");
        }
    }


    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
