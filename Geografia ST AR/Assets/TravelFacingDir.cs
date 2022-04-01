using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelFacingDir : MonoBehaviour
{
    public Transform[] targets;
    public float speed;
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targets[0].position, step);
        transform.rotation = Quaternion.Slerp(
        transform.rotation,
        Quaternion.LookRotation(targets[0].transform.position),
        Time.deltaTime * 0.5f
    );


    }
}
