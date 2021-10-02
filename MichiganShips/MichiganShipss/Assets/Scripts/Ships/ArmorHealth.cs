using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorHealth : ShipHealth
{
    public ShipHealth ownerHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void TakeDamage(int damage)
    {
        if(this.health > 0)
        {
            var trueDamage = damage / 2;
            this.health -= trueDamage;
            ownerHealth.TakeDamage(trueDamage);
        }
        else
        {
            Debug.Log($"{this.gameObject.name}.ShipHealth.TakeDamage: Dead!");
            ownerHealth.TakeDamage(damage);
        }
    }
}
