using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f; 
   
    void Update()
    {
       
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        
        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        
        transform.Translate(movementDirection * moveSpeed * Time.deltaTime);
    }
}
