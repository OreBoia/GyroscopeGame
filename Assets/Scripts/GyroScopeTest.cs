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


    private Rigidbody2D rb;

    private void Awake() 
    {
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        Screen.orientation = ScreenOrientation.Portrait;

        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    void Update()
    {

        text.text = Input.acceleration.ToString();
        rb.velocity = (Vector2) Input.acceleration.normalized * speed;
        
    }
}
