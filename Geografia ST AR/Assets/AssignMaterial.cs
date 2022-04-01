using UnityEditor;
using UnityEngine;
using System.Collections;

public class AssignMaterial : MonoBehaviour
{
    public Material red;
    private void Update()
    {
        for (int i = 0; i <= gameObject.transform.childCount; i++) {
            gameObject.transform.GetChild(i).GetComponent<MeshRenderer>().material = red;
        }
        

    }

}
