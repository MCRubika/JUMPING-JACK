using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   //Instance
    public static PlayerController pcInstance;
    //Déplacement
    public float movementSpeed;
    public Rigidbody2D rb;
    [Header("Jump")]
    public float JumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;
    public int i = 0;
    public int nombreDeSaut;
    public GameObject sautUI1;
    public GameObject sautUI2;
    private float distanceGround; 

    public GameObject player;
    public bool isJumping = false;

    float mx;

    private void Awake()
    {
        pcInstance = this;
    }

    private void Start()
    {
        distanceGround = feet.position.y - transform.position.y;
    }

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }

        if (Input.GetButtonDown("Jump") && IsGrounded()&& i < nombreDeSaut)
        {
            isJumping = true;
        }

        else
        {
            isJumping = false;
        }
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);
        rb.velocity = movement;
    }

    void Jump()
    {
        if (i < nombreDeSaut)
        {
            Vector2 movement = new Vector2(rb.velocity.x, JumpForce);
            rb.velocity = movement;
            i ++;
    
     
            if (i == 1)
            {
                sautUI1.SetActive(false);
            }
            else if (i == 2)
            {
                sautUI2.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                i = 0;
            }
        }
    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y + distanceGround), 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }
        return false;
    }

    public void StopPlayerController()
    {
      movementSpeed = 0;
      JumpForce = 0f;
    }

    public void RestaurePlayerController()
    {
        movementSpeed = 50;
        JumpForce = 20f;
    }
}
