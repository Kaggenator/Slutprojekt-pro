using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour{

    public GameObject player;

    void OnCollisionEnter(UnityEngine.Collision other)
    {

        if(other.collider.tag == "Obstacle")
        {
            //Avsluta spelet när man krockar
            Destroy(player);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
