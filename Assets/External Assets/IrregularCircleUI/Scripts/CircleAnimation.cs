using UnityEngine;
public class CircleAnimation : MonoBehaviour
{
	[SerializeField] GameObject[] animObjects;
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