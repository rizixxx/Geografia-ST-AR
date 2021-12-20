using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetsOrbit : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject target;

    public float OrbitSpeed;
    public Vector3 vec;
    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(transform.up * PlanetRotateSpeed * Time.deltaTime);

        transform.RotateAround(target.transform.position, vec , OrbitSpeed * Time.deltaTime);
        
    }
}
