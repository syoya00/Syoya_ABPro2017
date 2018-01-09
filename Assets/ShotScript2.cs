using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ShotScript2 : MonoBehaviour {

    private int count;

    // Use this for initialization
    void Start () {

        count = 0;

    }
	
	// Update is called once per frame
	void Update () {

        count++;

        if (count == 900)
        {
            SceneManager.LoadScene("main");
        }

    }
}
