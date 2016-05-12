using UnityEngine;
using System.Collections;

public class WheelManager : MonoBehaviour {

	public WheelCollider wc;

	// Use this for initialization
	void Start () {
		wc = GetComponent<WheelCollider>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.W)){
			wc.motorTorque = 1;
		}
	}
}
