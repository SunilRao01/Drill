using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	public bool kill = false;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (kill)
		{
			if (!particleSystem.IsAlive())
			{
				Destroy(gameObject);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player") && other.GetComponent<DrillControls>().drill)
		{
			audio.Play();
		}
	}
}
