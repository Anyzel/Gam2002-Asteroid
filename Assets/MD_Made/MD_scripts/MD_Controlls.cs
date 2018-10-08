using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MD_Controlls : MonoBehaviour {

    private float PCspeed;
    private float PCmaxspeed;
    private GameObject PlayerCharacter;
    private Rigidbody2D PCRB;
    private GameObject MTarget;
    private float RSpeed;
    //private Vector3 xav = new Vector3(0,0,0);

	// Use this for initialization
	void Start () {
        PCspeed = 0.4f;
        PCmaxspeed = 3.0f;
        PlayerCharacter = GameObject.FindGameObjectWithTag("PC");
        PCRB = PlayerCharacter.GetComponent<Rigidbody2D>();
        MTarget = GameObject.FindGameObjectWithTag("Target");
        RSpeed = 90f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            if (PCRB.velocity.magnitude > PCmaxspeed)
            {
                PCRB.velocity = PCRB.velocity.normalized * PCmaxspeed;
                //print("mvspeed is capped");
            }
            else
            {
                PCRB.AddForce(new Vector2(MTarget.transform.position.x - PlayerCharacter.transform.position.x, MTarget.transform.position.y - PlayerCharacter.transform.position.y ) * PCspeed);

                //PCRB.velocity = 0;
                //print("going...");
            }
            
        }

        if (Input.GetKey("a"))
        {
            //RotateParent.transform.Rotate(Vector3.up * RSpeed * Time.deltaTime);
            PlayerCharacter.transform.Rotate(Vector3.forward * RSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            //RotateParent.transform.Rotate(Vector3.up * RSpeed * Time.deltaTime);
            PlayerCharacter.transform.Rotate(Vector3.back * RSpeed * Time.deltaTime);
        }
		
	}
}
