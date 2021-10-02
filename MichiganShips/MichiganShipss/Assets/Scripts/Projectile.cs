using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Projectile : MonoBehaviour
{
    public float speed = 0.04f;
    public float maxDistance = 10f;

    float distanceTravelled = 0f;
    bool moving = false;
    string sourceTag;

    Action movementAction;
    CharacterController charControl;

    // Start is called before the first frame update
    void Start()
    {
        movementAction = new Action( () => {} );
        charControl = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(moving) MoveCannonball();
    }

    // Called when this hits something
    void OnControllerColliderHit(ControllerColliderHit col)
    {
        //If the two objects don't have the same tag...
        if(col.gameObject.tag != this.gameObject.tag && col.gameObject.tag != sourceTag)
        {
            Debug.Log($"{this.gameObject.name}.OnControllerColliderHit: hit {col.gameObject.name}");
            //Debug.Break();
            Destroy(this.gameObject);
        }
    }

    void MoveCannonball()
    {
        charControl.Move(this.gameObject.transform.up * speed);
        distanceTravelled += speed;

        if(distanceTravelled > maxDistance) Destroy(this.gameObject);
    }

    public void Launch(string ignoreTag)
    {
        //Step 0: Save the tag to ignore
        sourceTag = ignoreTag;

        //Step 1: Deparent Self
        this.gameObject.transform.parent = null;

        //Step 2: Update Movement Delegate
        moving = true;
    }

}
