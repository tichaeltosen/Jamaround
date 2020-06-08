using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacter : MonoBehaviour
{
    public float Speed;


    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
{
    float x = Input.GetAxis("x-axis");
    float y = Input.GetAxis("y-axis");
    Vector3 playerMovement = new Vector3(x, 0f, y) * Speed * Time.deltaTime;
    transform.Translate(playerMovement, Space.Self);
}    


}
