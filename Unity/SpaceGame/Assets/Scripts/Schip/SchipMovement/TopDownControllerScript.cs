using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownControllerScript : MonoBehaviour
{
    [Header("Ship settings")]
    public float accelerationFactor = 5.0f;
    public float turnFactor = 1.5f;
    public float maxSpeed = 8;

    //Local variables
    float accelerationInput = 0;
    float steeringInput = 0;

    float rotationAngle = 0;

    float velocityVsUp = 0;

    //Components
    Rigidbody2D shipRigidbody2D;

    //Awake is called when the script instance is being loaded.
    void Awake()
    {
        shipRigidbody2D = GetComponent<Rigidbody2D>();
    }

    //Frame-rate independent for physics calculations.
    void FixedUpdate()
    {
        ApplyEngineForce();

        ApplySteering();
    }

    void ApplyEngineForce()
    {

        //Apply drag if there is no accelerationInput so the ship stops when the player lets go of the accelerator
        if (Input.GetKey(KeyCode.LeftControl))
            shipRigidbody2D.drag = Mathf.Lerp(shipRigidbody2D.drag, 2.5f, Time.fixedDeltaTime * 3);
        else shipRigidbody2D.drag = 0;

        //Limit so we cannot go faster than the max speed in the "forward" direction
        if (velocityVsUp > maxSpeed && accelerationInput > 0)
            return;

        //Limit so we cannot go faster than the 50% of max speed in the "reverse" direction
        if (velocityVsUp < -maxSpeed*0.5f && accelerationInput < 0)
            return;

        //Limit so we cannot go faster in any direction while accelerating
        if (shipRigidbody2D.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
            return;

        //Create a force for the engine
        Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor;

        //Apply force and pushes the ship forward
        shipRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);
    }

    void ApplySteering()
    {
        //Update the rotation angle based on input
        rotationAngle -= steeringInput * turnFactor * turnFactor;

        //Apply steering by rotating the ship object
        shipRigidbody2D.MoveRotation(rotationAngle);
    }


    float GetLateralVelocity()
    {
        //Returns how how fast the ship is moving sideways. 
        return Vector2.Dot(transform.right, shipRigidbody2D.velocity);
    }


    public void SetInputVector(Vector2 inputVector)
    {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }

}
