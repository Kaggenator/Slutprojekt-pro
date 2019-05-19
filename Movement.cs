using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    public Rigidbody player;
    public float Xspeed;
    public float Zspeed;
    public float start;

    // Use this for initialization
    void Start()
    {
        Xspeed = 20f;
        Zspeed = 14f;
        start = player.position.z - player.position.z;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Accelerationen
        if(start % 2 == 0)
        {
            Zspeed = Zspeed + 0.02f;
        }

        transform.Translate(Xspeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, Zspeed * Time.deltaTime);

        //Om man faller av banan
        if(player.position.y < -3f)
        {
            Destroy(player);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
