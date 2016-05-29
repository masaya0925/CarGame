using UnityEngine;
using System.Collections;

public class Wheel : MonoBehaviour
{
	[SerializeField]
	private WheelCollider _collider = null;

	[SerializeField]
	private GameObject _view = null;

	public WheelCollider Collider { get { return _collider; }	}
	public GameObject View { get { return _view; }	}

}
