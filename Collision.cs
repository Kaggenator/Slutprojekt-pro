using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour{

    void OnCollisionEnter(UnityEngine.Collision other)
    {
        if(other.collider.tag == "Finish")
        {
            
        }
    }

}
