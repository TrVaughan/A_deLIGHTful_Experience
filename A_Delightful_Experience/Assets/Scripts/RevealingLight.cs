using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealingLight : MonoBehaviour
{
    public Light lightComponet;

    void Start()
    {
        lightComponet = GetComponent<Light>();
        lightComponet.enabled = false;
    }
}
