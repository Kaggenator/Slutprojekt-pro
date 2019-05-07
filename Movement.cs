using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody player;
    public float Xspeed;
    public float Zspeed;

    // Use this for initialization
    void Start()
    {
        Xspeed = 18f;
        Zspeed = 10f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Xspeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, Zspeed * Time.deltaTime);
    }
}
