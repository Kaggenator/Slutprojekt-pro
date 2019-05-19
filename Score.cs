using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public float start;

    // Use this for initialization
    void Start()
    {
        start = player.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Tar spelarens position minus startpositionen så att poängen börjar på noll
        scoreText.text = (player.position.z - start).ToString("0");
    }
}
