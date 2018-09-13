using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;
	public GameObject beam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += Vector3.forward * speed;
		transform.rotation = Quaternion.Euler (0, 0, 0);
	
		//上下左右に動くよ
		//wキーで上に動くよ
		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (0, 1, 0);
			transform.rotation = Quaternion.Euler (-30, 0, 0);
		}
		//sキーで下に動くよ
		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (0, -1, 0);
			transform.rotation = Quaternion.Euler (30, 0, 0);
		}
		//dキーで右に動くよ
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (1, 0, 0);
			transform.rotation = Quaternion.Euler (0, 30, 0);
		}
		//aキーで左に動くよ
		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (-1, 0, 0);
			transform.rotation = Quaternion.Euler (0, -30, 0);
		}

		//弾撃つよ
		if(Input.GetMouseButtonDown(0)){
			Instantiate (beam, this.transform.position, this.transform.rotation);
		}

	}
}
