using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSE : MonoBehaviour {

public AudioClip sound1;
AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {


   
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cubeTag" || collision.gameObject.tag == "groundTag")
        {
                audioSource.PlayOneShot(sound1);
            
        }
        else if (collision.gameObject.tag == "UnityChan")
        {
            audioSource.volume = 0;
        }

    }

}
