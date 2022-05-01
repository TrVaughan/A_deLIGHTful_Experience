using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGlow : MonoBehaviour
{
    public Material wallGlow;
    public Material notGlow;
    public GameObject gameWall;

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
           gameWall.GetComponent<MeshRenderer>().material = wallGlow;
           Invoke("ResetMaterial", 2f);            
        }
    }

     void ResetMaterial() 
     {
        gameWall.GetComponent<MeshRenderer>().material = notGlow; 
     }
}
