using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public Vector3 respawnPoint = Vector3.zero;
    public int outOfBoundsDamage = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        //If the triggering thing has a ship controller
        var ship = col.gameObject.GetComponent<ShipController>();
        if(ship != null)
        {
            //Damage its ship health
            col.gameObject.GetComponent<ShipHealth>().health -= outOfBoundsDamage;

            //And respawn it
            //the character controller needs to be toggled, or else the ship
            //will teleport back to its original position during lateupdate
            var control = col.gameObject.GetComponent<CharacterController>();
            control.enabled = false;
            col.gameObject.transform.position = respawnPoint;
            control.enabled = true;
        }
    }
}
