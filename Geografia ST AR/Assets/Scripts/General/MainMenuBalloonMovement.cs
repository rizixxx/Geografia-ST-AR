using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBalloonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public AnimationCurve myCurve;
    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);

    }
}
