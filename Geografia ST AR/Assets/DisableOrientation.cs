using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOrientation : MonoBehaviour
{
    public ScreenOrientation scr;
    private void Awake()
    {
        Screen.orientation = scr;
    }
}
