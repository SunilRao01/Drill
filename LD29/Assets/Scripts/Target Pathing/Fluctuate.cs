using UnityEngine;
using System.Collections;

public class Fluctuate : MonoBehaviour 
{
	public float distance;

	public bool xDirection;
	public bool yDirection;
	public bool zDirection;

	public bool positive;

	public float speed;
	
	void Start () 
	{
	
	}
	
	void Update () 
	{
		Vector3 tempPosition = new Vector3(0, 0, 0);

		if (xDirection)
		{
			if (positive)
			{
				tempPosition.x = Mathf.Sin(Time.time * speed) * distance;
			}
			else
			{
				tempPosition.x = -Mathf.Sin(Time.time * speed) * distance;
			}
		}
		else
		{
			tempPosition.x = transform.position.x;
		}

		if (yDirection)
		{
			if (positive)
			{
				tempPosition.y = Mathf.Sin(Time.time * speed) * distance;
			}
			else
			{
				tempPosition.y = -Mathf.Sin(Time.time * speed) * distance;
			}
		}
		else
		{
			tempPosition.y = transform.position.y;
		}

		if (zDirection)
		{
			if (positive)
			{
				tempPosition.z = Mathf.Sin(Time.time * speed) * distance;
			}
			else
			{
				tempPosition.z = -Mathf.Sin(Time.time * speed) * distance;
			}
		}
		else
		{
			tempPosition.z = transform.position.z;
		}

		transform.position = tempPosition;
	}
}
