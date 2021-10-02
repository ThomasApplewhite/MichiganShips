using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broadside : Cannon
{
    [Header("Broadside Settings")]
    public Cannon[] cannons;

    public float shotDelay = 0.1f;

    void Awake()
    {
        //Broadsides never track. Make individual cannons do it.
        this.trackOpponent = false;
    }

    public override void Shoot()
    {
        StartCoroutine(BroadsideRoutine());
    }

    IEnumerator BroadsideRoutine()
    {
        foreach(Cannon cannon in cannons)
        {
            cannon.Shoot();

            yield return new WaitForSeconds(0.1f);
        }
    }
}