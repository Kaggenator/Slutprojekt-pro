using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour{

    public GameObject player;

    void OnCollisionEnter(UnityEngine.Collision other)
    {
        if(other.collider.tag == "Obstacle")
        {
            Destroy(player);
        }
    }

}
