using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour {
    public float RotationTimeInDay = 1f;
	public Slider TimeSlider;

	void Update () {
		float anglePerSecond = 360 / Utils.convertRealTimeToGameTime (RotationTimeInDay, TimeSlider);
		transform.Rotate(new Vector3(0, anglePerSecond * Time.deltaTime, 0));
	}
}
