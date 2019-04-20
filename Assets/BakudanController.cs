using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakudanController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -0.2f, 0);

        if(transform.position.y < -10.0f)
        {
            Destroy(gameObject);
        }
    }
}
