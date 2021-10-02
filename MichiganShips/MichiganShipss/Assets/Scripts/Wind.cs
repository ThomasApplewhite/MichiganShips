using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float windSpeedBoost = 0.005f;
    public float windSpeedMaxBoost = 0.02f;
    public float maxChangePerCycle = 5f;
    public float cycleDuration = 5f;

    public Vector3 windDirection { get{ return this.gameObject.transform.up; } }

    Transform windTrans;
    float windNoiseCoord = 1f;
    float windNoiseChange = .75f;
    
    // Start is called before the first frame update
    void Start()
    {
        windTrans = this.gameObject.transform;
        windTrans.Rotate(new Vector3(0f, 0f, Mathf.PerlinNoise(windNoiseCoord, windNoiseCoord) * 360f));


        StartCoroutine(WindCycle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Perlin a new rotation to go to, then lerp over there over the course of
    //cycle duration seconds
    IEnumerator WindCycle()
    {
        float newForward;
        float oldForward;
        float timer;

        while(true)
        {
            oldForward = windTrans.up.z;
            newForward = windTrans.up.z + ((Mathf.PerlinNoise(windNoiseCoord, windNoiseCoord) * 2) - 1);

            windNoiseCoord += windNoiseChange;

            timer = 0f;
            while(timer < cycleDuration)
            {
                //Debug.Log($"{this.gameObject.name}.Wind.WindCycle: Lerping {oldForward} to {newForward}");
                //Vector3.Slerp(oldForward, newForward, timer / cycleDuration)
                windTrans.Rotate(0f, 0f, Mathf.Lerp(oldForward, newForward, timer / cycleDuration));

                yield return null;

                timer += Time.deltaTime;
            }

            windTrans.Rotate(0f, 0f, newForward);
        }
    }
}
