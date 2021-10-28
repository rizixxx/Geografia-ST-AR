using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class transp : MonoBehaviour
{
    public Image image;
    void Start()
    {

    }

    // Update is called once per frame

    public float rotn;
    void Update()
    {
        image = GetComponent<Image>();
        image.transform.Rotate(0, rotn, 0);
    }
}
