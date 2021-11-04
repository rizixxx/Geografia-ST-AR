using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyaround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = (target.position + new Vector3(0, 0, 0)) - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        transform.Translate(0, 0,  1.7f *Time.deltaTime);
    }
}
