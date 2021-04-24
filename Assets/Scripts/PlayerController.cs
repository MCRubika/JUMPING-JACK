using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   //Instance
    public static PlayerController pcInstance;
    //Déplacement
    public float movementSpeed;
    public Rigidbody2D rb;
    //Jump
    public float JumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;
    public int i = 0;
    public int nombreDeSaut;
    public GameObject sautUI1;
    public GameObject sautUI2;

    public GameObject player;

    float mx;



    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
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
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);
        if (groundCheck != null)
        {
            return true;
        }
        return false;

    }


}
