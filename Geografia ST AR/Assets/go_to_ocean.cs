using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class go_to_ocean : MonoBehaviour
{
    public GameObject lela;
    public GameObject thepath;
    public PathCreation.PathCreator path;
    Toggle toggle;
    private void Start()
    {
        toggle = gameObject.GetComponent<Toggle>();
        path = thepath.GetComponent<PathCreation.PathCreator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (toggle.isOn) {
            lela.GetComponent<PathCreation.Examples.PathFollower>().pathCreator = path;
                }
    }
}
