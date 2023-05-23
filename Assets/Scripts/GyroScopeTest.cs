using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroScopeTest : MonoBehaviour
{
    private Gyroscope gyroscope;
    public float speed;

    void Start()
    {
        if(SystemInfo.supportsGyroscope)
        {
            gyroscope = Input.gyro;
            gyroscope.enabled = true;
        }
        else
        {
            Debug.Log("Gyroscope not supported on this device.");
        }
    }

    void Update()
    {
        if(gyroscope != null)
        {
            Vector3 rotationRate = gyroscope.rotationRate; 
            
            transform.Rotate(-rotationRate.y, rotationRate.x, 0);

            transform.position += rotationRate.normalized * speed;
        }
    }
   
}
