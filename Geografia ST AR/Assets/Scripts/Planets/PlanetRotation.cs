using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }
    float RotateSpeed = -25.0f;
    public float side;
    public string scene;
    // Update is called once per frame
    void Update()
    {
        if (scene.Equals("main"))
        {
            transform.Rotate(transform.right * side * RotateSpeed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(transform.up * side * RotateSpeed * Time.deltaTime);
        }
    }
}
