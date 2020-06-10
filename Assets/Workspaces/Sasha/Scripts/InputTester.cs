using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetButtonDown("Talk"))
        {
            Debug.Log(Input.mousePosition);
        }
    }
}