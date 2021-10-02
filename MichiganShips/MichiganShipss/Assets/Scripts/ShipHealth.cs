using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : MonoBehaviour
{
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0) Debug.Log($"{this.gameObject.name}.ShipHealth.TakeDamage: Dead!");
    }
}
