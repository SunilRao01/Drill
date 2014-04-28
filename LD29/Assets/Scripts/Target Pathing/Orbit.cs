using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour 
{
	// Varying central rotation points
	public bool center;
	public Vector2 specifiedPoint;

	public float rotationSpeed;

	public bool positive;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		if (center)
		{
			Vector2 circleCenter = GameObject.Find("Circle").GetComponent<SpriteRenderer>().bounds.center;

			if (!positive)
			{
				transform.RotateAround(circleCenter, Vector3.forward, -Time.deltaTime * rotationSpeed);
			}
			else
			{
				transform.RotateAround(circleCenter, Vector3.forward, Time.deltaTime * rotationSpeed);
			}
		}
		else
		{
			if (!positive)
			{
				transform.RotateAround(specifiedPoint, Vector3.forward, -Time.deltaTime * rotationSpeed);
			}
			else
			{
				transform.RotateAround(specifiedPoint, Vector3.forward, Time.deltaTime * rotationSpeed);
			}
		}
	}
}
