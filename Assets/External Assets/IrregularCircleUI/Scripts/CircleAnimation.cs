using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class CircleAnimation : MonoBehaviour
{
	[SerializeField] GameObject[] animObjects;
	// Update is called once per frame
	private float angle_curve = 50f;
	void Update()
	{
		foreach (GameObject go in animObjects)
		{
			Vector3 angle = go.transform.eulerAngles;
			angle.z += Time.deltaTime * angle_curve;
			go.transform.eulerAngles = angle;
		}
	}
}
