using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rotateChange;
    void Start()
    {
        
    }
    float RotateSpeed = -25.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.right * -1 * RotateSpeed * Time.deltaTime);
    }
}
