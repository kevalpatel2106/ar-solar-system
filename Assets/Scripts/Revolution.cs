using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Revolution : MonoBehaviour {
	public float RevolutionTimeInDay = 1f;
	public GameObject ParentObject;
	public Slider TimeSlider;

	private float m_Radius = 1f;

	void Start(){
		m_Radius = Vector3.Distance(transform.position, ParentObject.transform.position);
	}

    void Update()
    {
		float anglePerSecond = 360 / Utils.convertRealTimeToGameTime (RevolutionTimeInDay, TimeSlider);
		this.transform.localPosition = GetPosition(Time.time * anglePerSecond * Mathf.PI / 180.0f);
    }

    private Vector3 GetPosition(float angle)
    {
        var x = m_Radius * Mathf.Sin(angle);
        var z = m_Radius * Mathf.Cos(angle);
        return new Vector3(x, 0, z);
    }
}
