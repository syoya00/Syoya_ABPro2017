using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class RopeScript : MonoBehaviour
{

    private int count;
    private int time;

    GameObject refObj1;
    GameObject refObj2;
    GameObject refObj3;
    GameObject refObj4;

    GameObject player;

    // Use this for initialization
    void Start()
    {
        count = 0;
        time = 900;

        refObj1 = GameObject.Find("Wall (1)");
        refObj2 = GameObject.Find("Wall (2)");
        refObj3 = GameObject.Find("Wall (3)");
        refObj4 = GameObject.Find("Wall (4)");

        player = GameObject.Find("RightController");

    }

    // Update is called once per frame
    void Update()
    {

        if (count == time)
        {
            if (player.transform.position.y>-10)
            {

                //Debug.Log(player.transform.position);

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
        if(count<time)
        {
            this.transform.position += new Vector3(0,0,0.005f);
        }

        count++;

        if (count == 1350)
        {
            SceneManager.LoadScene("main");
        }

    }
    
}
