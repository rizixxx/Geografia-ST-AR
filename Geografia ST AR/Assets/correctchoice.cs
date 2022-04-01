using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correctchoice : MonoBehaviour
{

    public void iscorrect()
    {
        GameObject.FindGameObjectWithTag("test").SetActive(false);
    }
}
