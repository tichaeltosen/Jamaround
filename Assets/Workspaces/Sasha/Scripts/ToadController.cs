using UnityEngine;
using System.Collections;

// This script moves the character controller forward
// and sideways based on the arrow keys.
// It also jumps when pressing space.
// Make sure to attach a character controller to the same game object.
// It is recommended that you make only one call to Move or SimpleMove per frame.

public class ToadController : MonoBehaviour
{

public float moveSpeed = 7.0f;
public float jumpSpeed = 7.0f;
public float gravityScale = 3.0f;
public float turnSpeed = 3.0f;

int jumpCount = 0;
public int maxJumps = 2; //max amount of jumps

Transform cam;

// public Rigidbody theRB;
public GameObject PlayerModel;
public CharacterController controller;
private Vector2 input;

private Vector3 moveDirection;

float angle;

Quaternion lookRotation;

void Start(){
    // theRB = GetComponent<Rigidbody>();
    controller = GetComponent<CharacterController>();
    Cursor.lockState = CursorLockMode.Locked;
    cam = Camera.main.transform;

    jumpCount = maxJumps;

}

void Update (){

//get input
input.x = Input.GetAxis("Horizontal");
input.y = Input.GetAxis("Vertical");
//calculate move direction relative to camera
float yStore = moveDirection.y;
moveDirection = (cam.forward * input.y * moveSpeed) + (cam.right * input.x * moveSpeed);
moveDirection = moveDirection.normalized * moveSpeed;
moveDirection.y = yStore;

        float horizontal = Input.GetAxis("Mouse X") * turnSpeed;
        transform.Rotate(0, horizontal, 0);

if (controller.isGrounded)
{
    Debug.Log("Player is Grounded");


moveDirection.y = 0f;//cancel out gravity when grounded
jumpCount = maxJumps; //and reset jumpcount
}

if (Input.GetButtonDown("Jump"))
{if (jumpCount > 0)
{
        Jump();
}
}

moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);

controller.Move(moveDirection * Time.deltaTime);

if(input.x != 0 || input.y != 0)
{
    transform.rotation = Quaternion.Euler(0f, cam.rotation.eulerAngles.y, 0f);
    Quaternion newRotation = Quaternion.LookRotation(new Vector3(moveDirection.x, 0f, moveDirection.z)); 
    PlayerModel.transform.rotation = Quaternion.Slerp(PlayerModel.transform.rotation, newRotation, turnSpeed * Time.deltaTime);
}

}

void Jump()
{
    Debug.Log("Jump!");
    jumpCount -= 1;
    moveDirection.y = jumpSpeed;
}
}