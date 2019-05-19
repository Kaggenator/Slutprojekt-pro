using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    public Vector3 FOV;

	// Use this for initialization
	void Start ()
    {
        transform.position = player.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Kamerans position när den följer spelaren
        transform.position = player.position + FOV;
	}
}
