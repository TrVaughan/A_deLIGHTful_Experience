using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanturnLight : MonoBehaviour
{
    private Light lanturnLight;
    private int lightCount;

    // Start is called before the first frame update
    void Start()
    {
        lanturnLight = GetComponent<Light>();
        lanturnLight.enabled = false;
        lightCount = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Projectile"))
        {
            lanturnLight.enabled = true;
            lightCount = lightCount +1;
        }
        
    }

    void Update()
    {
    }    
}
