using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setspeed : MonoBehaviour {
    Animator ani;
    float speed=0;
	// Use this for initialization
	void Start () {
        ani = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("a")) {
            speed++;
            ani.SetFloat("speed",speed);
        }
        if (Input.GetKey("b"))
        {
            speed--;
            ani.SetFloat("speed", speed);
        }
    }
}
