using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour{

    public GameObject player;

    void OnCollisionEnter(UnityEngine.Collision other)
    {
        if(other.collider.tag == "Obstacle" || other.collider.tag != "Track")
        {
            Destroy(player);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
