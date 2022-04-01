using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class U10PS_DissolveOverTime : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    public float speed = .5f;

    private void Start()
    {
        meshRenderer = this.GetComponent<MeshRenderer>();
        Material[] mats = meshRenderer.materials;
        mats[0].SetFloat("_Cutoff", 1f);

    }

    private float t = 0f;
    private float x = 1f;
    private void Update()
    {
        Material[] mats = meshRenderer.materials;
        x = 1 - (t / 1.5f);
        mats[0].SetFloat("_Cutoff", x);
        t += Time.deltaTime;
        if (x <= 0)
        {
            Destroy(this);
        }
    }


}
