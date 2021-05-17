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
    public int initSaut;

    private float distanceGround; 

    public GameObject player;
    public bool isJumping = false;

    float mx;

    private float timer;

    private void Awake()
    {
        pcInstance = this;
    }

    private void Start()
    {
        distanceGround = feet.position.y - transform.position.y;
        nombreDeSaut = 0;
    }

    private void Update()
    {
        nombreDeSaut = LevelManager.instance.augmentationSauts;

        mx = Input.GetAxisRaw("Horizontal");
        initSaut = 1 + nombreDeSaut;

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }

        if (isJumping)
        {
            timer += Time.deltaTime;

            if(timer > 0.5)
            {
                isJumping = false;
                timer = 0;
            }
        }

        /*if (Input.GetButtonDown("Jump") && i < initSaut)
        {
            isJumping = true;
        }

        else
        {
            isJumping = false;
        }*/
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);
        rb.velocity = movement;
    }

    void Jump()
    {
        if (i < initSaut)
        {
            Vector2 movement = new Vector2(rb.velocity.x, JumpForce);
            rb.velocity = movement;
            i ++;

            isJumping = true;

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
        movementSpeed = 8;
        JumpForce = 20f;
    }
}
