// using UnityEngine;
// using System.Collections;

// public class InputTester : MonoBehaviour
// {
// //input actions
// PrototypeInputSystem controls;

// //movement
// Vector2 movementInput;
// //look input
// Vector2 lookInput;

// void onEnable(){controls.Enable();}
// void onDisable(){controls.Disable();}

// void Awake(){
//     controls = new PrototypeInputSystem();
//     controls.Player.Walk.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
//     controls.Player.Look.performed += ctx => lookInput = ctx.ReadValue<Vector2>();
// }
// void FixedUpdate(){
// }

// void Update(){
//     Debug.Log(InputControl<movementInput>.ReadUnprocessedValue());
// }

// void Rotate(){
// }

// }