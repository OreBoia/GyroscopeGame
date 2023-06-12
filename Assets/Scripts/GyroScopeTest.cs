using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GyroScopeTest : MonoBehaviour
{
    private Gyroscope gyroscope;
    public float speed;
    private float borderSize = 0f;
    public TextMeshProUGUI text;

    private void Awake() 
    {
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        Screen.orientation = ScreenOrientation.Portrait;
    }

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

            //update text
            text.text = rotationRate.ToString();
            
            // transform.Rotate(rotationRate.y, rotationRate.x, 0);

            transform.position += rotationRate.normalized * speed;
        }



        // Clamp();
    }

    private void Clamp()
    {
        Vector3 playerScreenPosition = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 clampedPosition = transform.position;

        float borderWidth = 50f;
        float borderX = Mathf.Clamp(clampedPosition.x, borderWidth, Screen.width - borderWidth);
        float borderY = Mathf.Clamp(clampedPosition.y, borderWidth, Screen.height - borderWidth);

        if (playerScreenPosition.x <= borderWidth)
        {
            clampedPosition.x += playerScreenPosition.x - borderWidth;
        }
        else if (playerScreenPosition.x >= Screen.width - borderWidth)
        {
            clampedPosition.x += playerScreenPosition.x - (Screen.width - borderWidth);
        }

        if (playerScreenPosition.y <= borderWidth)
        {
            clampedPosition.y += playerScreenPosition.y - borderWidth;
        }
        else if (playerScreenPosition.y >= Screen.height - borderWidth)
        {
            clampedPosition.y += playerScreenPosition.y - (Screen.height - borderWidth);
        }

        transform.position = clampedPosition;

    }
}
