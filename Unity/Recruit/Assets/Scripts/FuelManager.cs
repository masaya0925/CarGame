using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FuelManager : MonoBehaviour {
	[SerializeField]
	private RectTransform _rectTransform = null;

	[SerializeField]
	private float _maxValue = 1;
	public float MaxValue {
		get {
			return _maxValue;
		}
		set{
			_maxValue = value;
			UpdateValue ();
		}
	}

	[SerializeField]
	private float _value = 1;
	public float Value {
		get {
			return _value;
		}
		set{
			_value = value;
			UpdateValue ();
		}
	}

	private float _width;

	private void Start()
	{
		_width = _rectTransform.sizeDelta.x;
	}

	private void UpdateValue() {
		var p =  _value / _maxValue;
		//Debug.Log (_rectTransform.sizeDelta);
		_rectTransform.sizeDelta = new Vector2(_width * p , _rectTransform.sizeDelta.y);			
	}
}
