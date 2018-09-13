using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour {

    public float beamSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.TransformDirection(Vector3.forward * beamSpeed);
	}

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Enemy"){
            Destroy(this.gameObject);
        }
    }
}
