using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {

    public Texture face1;
    public Texture face2;
    public Texture face3;
    public Texture face4;
    public Texture face5;
    public Texture face6;
    public Texture w1;
    public Texture w2;
    public Texture w3;
    public Texture w4;
    public Texture w5;
    public Texture r1;
    public Texture r2;
    public Texture r3;
    public Texture r4;
    public Texture r5;
    public Texture nice;
    public GameObject dice;

    private AudioSource niceS;

    // Use this for initialization
    void Start ()
    {
        niceS = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

	}

    public void ChangeTexture(int n)
    {
        Renderer render = GetComponent<Renderer>();
        if (n==1)
        {
            render.material.mainTexture = face1;
        }
        else if (n==2)
        {
            render.material.mainTexture = face2;
        }
        else if (n == 3)
        {
            render.material.mainTexture = face3;
        }
        else if (n == 4)
        {
            render.material.mainTexture = face4;
        }
        else if (n == 5)
        {
            render.material.mainTexture = face5;
        }
        else if (n == 6)
        {
            render.material.mainTexture = face6;
        }
        else if (n == 11)
        {
            render.material.mainTexture = w1;
        }
        else if (n == 12)
        {
            render.material.mainTexture = w2;
        }
        else if (n == 13)
        {
            render.material.mainTexture = w3;
        }
        else if (n == 14)
        {
            render.material.mainTexture = w4;
        }
        else if (n == 15)
        {
            render.material.mainTexture = w5;
        }
        else if (n == 21)
        {
            render.material.mainTexture = r1;
        }
        else if (n == 22)
        {
            render.material.mainTexture = r2;
        }
        else if (n == 23)
        {
            render.material.mainTexture = r3;
        }
        else if (n == 24)
        {
            render.material.mainTexture = r4;
        }
        else if (n == 25)
        {
            render.material.mainTexture = r5;
        }
        else if (n==31)
        {
            render.material.mainTexture = nice;
            niceS.PlayOneShot(niceS.clip);
        }
    }
}
