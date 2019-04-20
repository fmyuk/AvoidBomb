using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakudanGenerator : MonoBehaviour {

    public GameObject BakudanPrefab;
    float span = 0.5f;
    float delta = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject Bakudan = Instantiate(BakudanPrefab) as GameObject;
            int x = Random.Range(-7, 7);
            Bakudan.transform.position = new Vector3(x, 4, 0);
        }
    }
}
