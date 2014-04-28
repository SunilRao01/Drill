using UnityEngine;
using System.Collections;

public class EndMenuSelector : MonoBehaviour 
{
	private bool onStart = true;
	private bool onQuit = false;

	private Vector3 startPosition;
	private Vector3 quitPostiion;

	// Use this for initialization
	void Start () 
	{
		startPosition = transform.position;

		quitPostiion = transform.position;
		quitPostiion.x = 0.8056858f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
		{
			if (onStart && !onQuit)
			{
				onQuit = true;
				onStart = false;

				transform.position = quitPostiion;
			}
		}
		if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
		{
			if (onQuit && !onStart)
			{
				onQuit = false;
				onStart = true;

				transform.position = startPosition;
			}
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (onStart)
			{
				Application.LoadLevel("Story-Introduction");
			}
		}
	}
}
