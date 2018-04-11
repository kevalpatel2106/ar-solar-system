using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
    public float RotationTimeInDay = 1f;

	void Update () {
		transform.Rotate(new Vector3(0, calculateAnglePerSeconds() * Time.deltaTime, 0));
	}

	private float calculateAnglePerSeconds(){
		return 360 / (Configs.getSecondsInGame(RotationTimeInDay));
	}
}
