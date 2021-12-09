using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeitbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private bool beingHandled = false;

    public AnimationCurve myCurve;
    void Update()
    {
        //GameObject.FindGameObjectWithTag("first_button").transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            GameObject ob;
            bool pos = true;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    if (hit.collider.name.Equals("Button") && !beingHandled)
                    {
                        {
                            StartCoroutine(HandleIt());

                        }


                    }
                }
            }
        }
    }
    private IEnumerator HandleIt()
    {
        beingHandled = true;
        // process pre-yield
        GameObject.FindGameObjectWithTag("first_button").transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);

        yield return new WaitForSeconds(0.8f);
        // process post-yield
        beingHandled = false;
    }
}
