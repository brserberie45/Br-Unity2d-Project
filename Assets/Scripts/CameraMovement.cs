using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    Vector3 velocity;
    bool isGrounded;
    public float speeD = 17f;
    // Update is called once per frame

    Rigidbody rb;
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float verticalInput = 10f;

    //[SerializeField] float jumpForce = 10f;

    private void Start()
    {

        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {


        float horizontalInput = Input.GetAxis("Horizontal");


        rb.velocity = new Vector3(horizontalInput * movementSpeed, verticalInput * movementSpeed);


        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        /*
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        */
    }
}