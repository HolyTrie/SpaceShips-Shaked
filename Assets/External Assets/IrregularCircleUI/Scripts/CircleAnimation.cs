using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleAnimation : MonoBehaviour
{
	public GameObject[] animObjects;
	// Update is called once per frame
	void Update()
	{
		foreach (GameObject go in animObjects)
		{
			Vector3 angle = go.transform.eulerAngles;
			angle.z += Time.deltaTime * 50f;
			go.transform.eulerAngles = angle;
		}
	}
}
