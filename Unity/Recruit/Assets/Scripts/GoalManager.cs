using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GoalManager : MonoBehaviour {
	[SerializeField]
	private Text _text = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col) {
		var car = col.gameObject.GetComponent<WheelManager>();
		if (car != null) {
			_text.text = "Goal";
		}
	}
}
