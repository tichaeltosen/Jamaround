using UnityEngine;
using System.Collections;

// This script moves the character controller forward
// and sideways based on the arrow keys.
// It also jumps when pressing space.
// Make sure to attach a character controller to the same game object.
// It is recommended that you make only one call to Move or SimpleMove per frame.

public class LuigiController : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 7.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float turnSpeed = 7.0f;
Vector2 input;
float angle;

Quaternion targetRotation;
Transform cam;


    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        cam = Camera.main.transform;

        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
input.x = Input.GetAxisRaw("Horizontal");
input.y = Input.GetAxisRaw("Vertical");

if (Mathf.Abs(input.x) < 1 && Mathf.Abs(input.y) < 1) return;

    angle = Mathf.Atan2(input.x, input.y);
    angle = Mathf.Rad2Deg * angle;
    angle += cam.eulerAngles.y;

targetRotation = Quaternion.Euler(0, angle, 0);
transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);


        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            // moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            

            moveDirection = (transform.forward * input.y);

            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
    }
}