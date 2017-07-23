using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {
	public int speed;
	public int rotationSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W))
			gameObject.transform.Translate (Vector3.forward * speed * Time.deltaTime);
		if (Input.GetKey (KeyCode.D))
			gameObject.transform.Translate (Vector3.right * speed * Time.deltaTime);
		if (Input.GetKey (KeyCode.A))
			gameObject.transform.Translate (Vector3.left * speed * Time.deltaTime);
		if (Input.GetKey (KeyCode.S))
			gameObject.transform.Translate (Vector3.back * speed * Time.deltaTime);
		if (Input.GetKey (KeyCode.E))
			gameObject.transform.Rotate (Vector3.up, rotationSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.Q))
			gameObject.transform.Rotate (Vector3.down, rotationSpeed * Time.deltaTime);
		

	}
}
