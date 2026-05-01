using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float maxSpeed = 70f;
    public float acceleration = 15f; 
    public float friction = 6f;     
    public float resistance = 1f;
    public float rotationSpeed = 50f;
    public float gravity = -9.81f;
    public float rotation;
    public float cs;
    private Vector2 moveInput; 
    private bool isAccelerating;
    private bool isBreaking;
    public bool itempressed;
   
    public void OnDrift(InputValue val)
    {
        itempressed = val.isPressed;
    }
    private Vector3 verticalVelocity;
    public float currentSpeed = 0f; 

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    
    public void OnAccelerate(InputValue value)
    {
        isAccelerating = value.isPressed;
        
    }

    public void OnBreak(InputValue value)
    {
        isBreaking = value.isPressed;
    }

    void Update()
    {
        cs = currentSpeed;
        rotation = moveInput.x * rotationSpeed * Time.deltaTime / resistance;
        transform.Rotate(0, rotation, 0);

       
        if (isAccelerating)
        {
            resistance = 2;
            currentSpeed += acceleration * Time.deltaTime;
        }
        else
        {
            resistance = 1;
            currentSpeed -= friction * Time.deltaTime;
        }
        if (isBreaking)
        {
            currentSpeed -= 7 * Time.deltaTime;
        }
        currentSpeed = Mathf.Clamp(currentSpeed, 0, maxSpeed);

        Vector3 move = transform.forward * currentSpeed;
        controller.Move(move * Time.deltaTime);

        if (controller.isGrounded && verticalVelocity.y < 0)
            verticalVelocity.y = -2f;
        
        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
    }
}
