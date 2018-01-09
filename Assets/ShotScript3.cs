using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript3 : MonoBehaviour {

    private AudioSource brust;

    // Use this for initialization
    void Start () {

        brust = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {
		
	}
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("wei");
        if (collision.gameObject.tag=="Balloon")
        {
            Debug.Log("soiya");
            brust.PlayOneShot(brust.clip);
        }
    }
}
