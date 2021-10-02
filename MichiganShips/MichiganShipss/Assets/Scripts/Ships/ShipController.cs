using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class ShipController : MonoBehaviour
{
    [Header("Speed Settings")]
    public float maxAcceleration = 5f;
    public float maxSlowdown = -15f;
    public float maxSpeed = 15f;
    public float maxReverseSpeed = -5f;
    public string windTag = "Wind";

    [Header("Turn Settings")]
    //How hard the ship can turn in 1 second
    public float maxTurnChange = 15f;
    //How hard the ship can turn at all
    public float maxTurn = 45f;

    [Header("Cannons")]
    public Cannon starboardBroadside;
    public Cannon starboardDeckGun;
    public Cannon portBroadside;
    public Cannon portDeckGun;

    readonly float tickCount = 60f;

    float currentTurn = 0f;
    float currentSpeed = 0f;

    Vector2 moveInputs = Vector2.zero;

    CharacterController charControl;
    Transform shipTrans;
    Wind wind;

    // Start is called before the first frame update
    void Start()
    {
        charControl = this.GetComponent<CharacterController>();
        shipTrans = this.gameObject.transform; //this is purely for convinience

        var shipCam = GetComponentInChildren<Camera>();
        if(this.gameObject.tag == "P1")
        {
            shipCam.rect = new Rect(0f, 0f, 0.5f, 1f);
        }
        else if(this.gameObject.tag == "P2")
        {
            shipCam.rect = new Rect(0.5f, 0f, 0.5f, 1f);
        }
        else
        {
            Debug.LogWarning($"{this.gameObject.name}.ShipController.Start(): No correct tag, disabling camera");
            shipCam.enabled = false;
        }

        wind = GameObject.FindWithTag(windTag).GetComponent<Wind>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Step 1: Calculate how much the ship should be turning this frame
        
        //If the player is holding left or right, add the below amount to the amount they're turning
        //moveInputs needs to be negated because input left is negative but rotate left is positive
        currentTurn = (maxTurnChange / tickCount) * -moveInputs.x;
        
        //I wrote this block to prevent ships from turning on a dime, but it doesn't work and I might not even
        //need it.
        //If that number's too big though, clamp it.
        /*if(Mathf.Abs(currentTurn - shipTrans.localEulerAngles.z) <= 0.001f)
        {
            //If currentTurn is less than 0, the max needs to be negative too
            currentTurn = 0;//currentTurn < 0 ? -maxTurn : maxTurn;
        }*/
        

        //Step 2: Calculate how fast the ship should be going

        //The number that should be added depends on whether or noth the player should be moving backwards or forwards
        var speedAdd = moveInputs.y >= 0 ? maxAcceleration : maxSlowdown;
        currentSpeed += (speedAdd / tickCount) * moveInputs.y;

        if(currentSpeed > maxSpeed || currentSpeed < maxReverseSpeed)
        {
            currentSpeed = currentSpeed < 0 ? maxReverseSpeed : maxSpeed;
        }

        //Step 2.5: Increase/Decrease Speed based on direction relative to wind
        currentSpeed += wind.windSpeedBoost * Vector3.Dot(shipTrans.up, wind.windDirection);

        //Step 3: Rotate the Ship on the Z axis (since it moves on the X and Y axis)
        shipTrans.Rotate(0f, 0f, currentTurn);

        //Step 4: Move the Ship, which always moves in the direction of its relative forward vector
        //Which in our case is "up"
        charControl.Move(shipTrans.up * currentSpeed);
    }

    public void UpdateMoveInputs(InputAction.CallbackContext context)
    {
        moveInputs = context.ReadValue<Vector2>();
    }

    public void ShootPort()
    {
        portBroadside.Shoot();
        portDeckGun.Shoot();
    }

    public void ShootStarboard()
    {
        starboardBroadside.Shoot();
        starboardDeckGun.Shoot();
    }

    public void Die()
    {
        SceneSwitcher.previousLoser = this.gameObject.name;
        SceneSwitcher.SwitchRestart();
    }
}
