using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class NextScene : MonoBehaviour
{
    public GameObject Player;

    double timer;
    int waitingTime;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0;
        waitingTime = 10;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitingTime && Seed.score >= 100)
        {
            SceneManager.LoadScene("Summer");
        }
    }
}
