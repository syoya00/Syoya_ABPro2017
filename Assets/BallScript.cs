using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {

    private int count;

    GameObject refObj1;
    GameObject refObj2;
    GameObject refObj3;
    GameObject refObj4;

    private AudioSource drop;

    // Use this for initialization
    void Start () {

        count = 0;

        refObj1 = GameObject.Find("Wall (1)");
        refObj2 = GameObject.Find("Wall (2)");
        refObj3 = GameObject.Find("Wall (3)");
        refObj4 = GameObject.Find("Wall (4)");

        drop = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

        count++;

        if (count==900)
        {
            SceneManager.LoadScene("main");
        }
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="Floor")
        {
            drop.PlayOneShot(drop.clip);
        }
        if (collision.gameObject.tag == "Pin")
        {
            WallScript w1 = refObj1.GetComponent<WallScript>();
            w1.ChangeTexture(31);
            WallScript w2 = refObj2.GetComponent<WallScript>();
            w2.ChangeTexture(31);
            WallScript w3 = refObj3.GetComponent<WallScript>();
            w3.ChangeTexture(31);
            WallScript w4 = refObj4.GetComponent<WallScript>();
            w4.ChangeTexture(31);

        }
    }
}
