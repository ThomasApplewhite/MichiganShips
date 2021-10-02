using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatUITracker : MonoBehaviour
{
    [Tooltip("Hah! Owner-ship, get it?")]
    public string ownerShip;
    GameObject owner;

    [Header("Wind Direction")]
    public GameObject windCompass;

    [Header("North Direction")]
    public GameObject northCompass;

    [Header("Speed Indicator")]
    public Text speedText;
    CharacterController shipControl;

    [Header("Health Indicators")]
    //public Text hullIndicator;
    public Text[] healthIndicators;
    //ShipHealth hull;
    ShipHealth[] healths;
    // Start is called before the first frame update
    void Start()
    {
        owner = GameObject.FindWithTag(ownerShip);

        shipControl = owner.GetComponent<CharacterController>();

        //hull = owner.GetComponent<ShipHealth>();
        healths = owner.transform.GetComponentsInChildren<ShipHealth>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateWind();
        UpdateNorth();
        UpdateSpeed();
        UpdateHealth();
    }

    void UpdateWind()
    {
        //nothing yet
    }

    void UpdateNorth()
    {
        northCompass.transform.up = Vector3.up - owner.transform.up;
    }

    void UpdateSpeed()
    {
        speedText.text = $"Speed: {shipControl.velocity.magnitude}";
    }

    void UpdateHealth()
    {
        //hullIndicator.text = $"{hull.gameObject.name} Health: {hull.health}";
        for(int i = 0; i < healthIndicators.Length; ++i)
        {
            healthIndicators[i].text = $"{healths[i].gameObject.name}: {healths[i].health}";
        }
    }
}
