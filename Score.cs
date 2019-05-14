using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text score;
    public float start;
    public string complete = "Level complete!";
    public string fail = "Game over!";

    // Use this for initialization
    void Start()
    {
        start = player.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = (((player.position.z - start) / 200) * 100).ToString("0") + ("%");
        if (score.text == "100%")
        {
            score.text = (complete);
        }
        else
        {

        }
    }
}
