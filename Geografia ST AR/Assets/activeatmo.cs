using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activeatmo : MonoBehaviour
{
    
    public GameObject cube;
    GameObject safecube;
    Slider toggle;
    Transform cubePos;
    private void Start()
    {
        toggle = gameObject.GetComponent<Slider>();
        safecube = Instantiate(cube, cube.transform.position, cube.transform.rotation);
    }
    
    void Update()
    {
        if (toggle.value == 1)
        {
            cube.SetActive(true); 
        }
        else
        {
            
            cube.SetActive(false);
            Destroy(cube);
            cube = Instantiate(safecube, cube.transform.position, cube.transform.rotation);
            
        }

    }
}
