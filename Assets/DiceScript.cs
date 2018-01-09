using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class DiceScript : MonoBehaviour {

    private int count;
    private bool drop;

    private int interval;
    private int tick;

    private int result = 0;

    private AudioSource drumroll;

    GameObject refObj1;
    GameObject refObj2;
    GameObject refObj3;
    GameObject refObj4;

    // Use this for initialization
    void Start () {
        count = 0;
        drop = false;

        refObj1 = GameObject.Find("Wall (1)");
        refObj2 = GameObject.Find("Wall (2)");
        refObj3 = GameObject.Find("Wall (3)");
        refObj4 = GameObject.Find("Wall (4)");

        interval = 96;
        tick = interval;

        drumroll = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (drop)
        {
            count++;
        }
        if (count == 120)
        {
            Vector3 check_1 = transform.TransformDirection(Vector3.forward);
            Vector3 check_4 = transform.TransformDirection(Vector3.right);
            Vector3 check_5 = transform.TransformDirection(Vector3.up);


            if (Mathf.Abs(Mathf.Round(check_1.y)) != 1)
            {
                if (Mathf.Abs(Mathf.Round(check_4.y)) != 1)
                {
                    if (Mathf.Round(check_5.y) == 1)
                    {
                        result = 5;
                    }
                    else
                    {
                        result = 6;
                    }
                }
                else
                {
                    if (Mathf.Round(check_4.y) == 1)
                    {
                        result = 4;
                    }
                    else
                    {
                        result = 3;
                    }
                }
            }
            else
            {
                if (Mathf.Round(check_1.y) == 1)
                {
                    result = 2;
                }
                else
                {
                    result = 1;
                }
            }

            WallScript w1 = refObj1.GetComponent<WallScript>();
            w1.ChangeTexture(result);
            WallScript w2 = refObj2.GetComponent<WallScript>();
            w2.ChangeTexture(result);
            WallScript w3 = refObj3.GetComponent<WallScript>();
            w3.ChangeTexture(result);
            WallScript w4 = refObj4.GetComponent<WallScript>();
            w4.ChangeTexture(result);

        }
        if (count >= 300&&count<300+interval*5)
        {

            if (count==300)
            {
                drumroll.PlayOneShot(drumroll.clip);
            }

            if ((count-300)%tick==0)
            {
                if (count < 300 + interval)
                {
                    CountDown(15);
                }
                else if (count < 300 + interval * 2)
                {
                    CountDown(14);
                }
                else if (count < 300 + interval * 3)
                {
                    CountDown(13);
                }
                else if (count < 300 + interval * 4)
                {
                    CountDown(12);
                }
                else if (count < 300 + interval * 5)
                {
                    CountDown(11);
                }
            }else if ((count-300)%tick==tick/2)
            {
                if (count < 300 + interval)
                {
                    CountDown(25);
                }
                else if (count < 300 + interval * 2)
                {
                    CountDown(24);
                }
                else if (count < 300 + interval * 3)
                {
                    CountDown(23);
                }
                else if (count < 300 + interval * 4)
                {
                    CountDown(22);
                }
                else if (count < 300 + interval * 5)
                {
                    CountDown(21);
                }

            }

            if ((count - 300) % interval == interval - 1)
            {
                Debug.Log((count - 300) / interval);
                tick = tick / 2;
            }
        }

        if (count >= 300 + interval * 5)
        {

            if (result == 1)
            {
                SceneManager.LoadScene("Sball");
            }
            else if (result == 2)
            {
                SceneManager.LoadScene("Sshot");
            }
            else if (result == 3)
            {
                SceneManager.LoadScene("Srope");
            }
            else if (result == 4)
            {
                SceneManager.LoadScene("Mball");
            }
            else if (result == 5)
            {
                SceneManager.LoadScene("Mshot");
            }
            else if (result == 6)
            {
                SceneManager.LoadScene("Mrope");
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            drop = true;
            count = 0;
            tick = interval;

        }
    }

    void CountDown(int c)
    {
        WallScript w1 = refObj1.GetComponent<WallScript>();
        w1.ChangeTexture(c);
        WallScript w2 = refObj2.GetComponent<WallScript>();
        w2.ChangeTexture(c);
        WallScript w3 = refObj3.GetComponent<WallScript>();
        w3.ChangeTexture(c);
        WallScript w4 = refObj4.GetComponent<WallScript>();
        w4.ChangeTexture(c);
    }
}
