using UnityEngine;
using System.Collections;

public class TimeBubble : MonoBehaviour 
{
	private float originalSpeed;
	private float originalSpeed2;

	private float halvedSpeed;
	private float halvedSpeed2;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		halvedSpeed = originalSpeed / 2;
		halvedSpeed2 = originalSpeed2 / 2;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			other.GetComponent<DrillControls>().drillSpeed = 0.05f;
		}

		if (other.CompareTag("Target"))
		{
			if (other.gameObject.name == "DoubleFluctuatingTarget")
			{
				originalSpeed = other.GetComponents<Fluctuate>()[0].speed;
				originalSpeed2 = other.GetComponents<Fluctuate>()[1].speed;

				halvedSpeed = originalSpeed / 2;
				halvedSpeed2 = originalSpeed2 / 2;

				other.GetComponents<Fluctuate>()[0].speed = halvedSpeed;
				other.GetComponents<Fluctuate>()[1].speed = halvedSpeed2;
			}
			if (other.gameObject.name == "FluctuatingTarget")
			{
				originalSpeed = other.GetComponents<Fluctuate>()[0].speed;

				halvedSpeed = originalSpeed / 2;

				other.GetComponent<Fluctuate>().speed = halvedSpeed;
			}
			if (other.gameObject.name == "OrbitTarget")
			{
				originalSpeed = other.GetComponents<Orbit>()[0].rotationSpeed;
				
				halvedSpeed = originalSpeed / 2;
				
				other.GetComponent<Fluctuate>().speed = halvedSpeed;
			}
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			other.GetComponent<DrillControls>().drillSpeed = 0.1f;
		}

		if (other.CompareTag("Target"))
		{
			if (other.gameObject.name == "DoubleFluctuatingTarget")
			{
				other.GetComponents<Fluctuate>()[0].speed = originalSpeed;
				other.GetComponents<Fluctuate>()[1].speed = originalSpeed2;
			}
			if (other.gameObject.name == "FluctuatingTarget")
			{
				other.GetComponent<Fluctuate>().speed = originalSpeed;
			}
			if (other.gameObject.name == "OrbitTarget")
			{
				other.GetComponent<Fluctuate>().speed = originalSpeed;
			}
		}
	}
}
