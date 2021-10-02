using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject projectilePrefab;

    public Transform launchPoint;

    public string sourceTag;

    [Header("Tracking Settings")]
    public bool trackOpponent = false;
    public string opponentTagToTrack;
    public float maxTrackRange = 2f;
    public float maxTrackAngle = 60f;
    [Range(0f, 1f)]
    public float turnPercentagePerTick = 0.016f;

    GameObject opponent;
    Transform cannonTrans; //for convinience

    float startingZAngle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        cannonTrans = this.gameObject.transform;
        startingZAngle = cannonTrans.localEulerAngles.z;

        if(trackOpponent)
        {
            try
            {
                opponent = GameObject.FindWithTag(opponentTagToTrack);
            }
            catch (UnityEngine.UnityException)
            {
                Debug.LogError($"{this.gameObject.name}.Cannon.Start: Opponent with tag {opponentTagToTrack} not found!");
                trackOpponent = false;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(trackOpponent) AimAtTarget();
    }

    void AimAtTarget()
    {
        if(
            cannonTrans.localEulerAngles.z >= startingZAngle + maxTrackAngle||
            cannonTrans.localEulerAngles.z <= startingZAngle - maxTrackAngle ||
            Vector2.Distance(cannonTrans.position, opponent.transform.position) > maxTrackRange
        )
        {
            //Debug.Log($"{this.gameObject.name}.Cannon.AimAtTarget: opponent too far or at bad angle." + 
            //    $"Distance is {Vector2.Distance(cannonTrans.position, opponent.transform.position)}");
            return;
        }

        var directionToTarget = opponent.transform.position - cannonTrans.position;
        cannonTrans.up = Vector2.Lerp(cannonTrans.up, directionToTarget, turnPercentagePerTick);
    }

    public virtual void Shoot()
    {
        Instantiate(projectilePrefab, launchPoint).GetComponent<Projectile>().Launch(sourceTag);

    }
}
