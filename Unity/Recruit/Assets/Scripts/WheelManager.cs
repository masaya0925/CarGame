using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class WheelManager: MonoBehaviour {
	[SerializeField]
	private FuelManager _fuelManager = null;
	[SerializeField]
	private Text _text = null;
	[SerializeField]
	private float DownForce = 100f;
	public List<AxleInfo> axleInfos; // the information about each individual axle
	public float maxMotorTorque; // maximum torque the motor can apply to wheel
	public float maxSteeringAngle; // maximum steer angle the wheel can have

	public void FixedUpdate()
	{
		var v = Input.GetAxis("Vertical");
		var motor = maxMotorTorque * v;
		var steering = maxSteeringAngle * Input.GetAxis("Horizontal");

		_fuelManager.Value -= Mathf.Abs(v);

		foreach (AxleInfo axleInfo in axleInfos) {
			if (axleInfo.steering) {
				axleInfo.leftWheel.Collider.steerAngle = steering;
				axleInfo.rightWheel.Collider.steerAngle = steering;
				axleInfo.leftWheel.View.transform.localRotation = Quaternion.Euler(0, steering, 90);
				axleInfo.rightWheel.View.transform.localRotation = Quaternion.Euler(0, steering, 90);
			}
			if (axleInfo.motor) {
				axleInfo.leftWheel.Collider.motorTorque = motor;
				axleInfo.rightWheel.Collider.motorTorque = motor;
			}
			if(_fuelManager.Value <= 0){
				_text.text = "Game Over";
			}

			axleInfo.leftWheel.View.transform.Rotate (0, motor, 0, Space.Self);
			axleInfo.rightWheel.View.transform.Rotate (0, motor, 0, Space.Self);
		}
	}
}

 
[System.Serializable]
public class AxleInfo {
	public Wheel leftWheel;
	public Wheel rightWheel;

	public bool motor; // is this wheel attached to motor?
	public bool steering; // does this wheel apply steer angle?
}