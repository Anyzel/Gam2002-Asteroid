using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MD_Warp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.tag == ("Xside")){
            print("hit side");
            transform.position = new Vector2 (transform.position.x * -1, transform.position.y);
        }
        if (other.gameObject.tag == ("Yside")){
            transform.position = new Vector2(transform.position.x, transform.position.y * -1);
            print("hit top/bot");
        }
	}
}
