using UnityEngine;
using System.Collections;

public class Circle : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		transform.eulerAngles = new Vector3(0, 0, (Random.Range(0.0f, 360.0f)));
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			other.GetComponentInChildren<ParticleSystem>().Play();
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			GameObject.Find("DirtTrail(Clone)").transform.parent = transform;

			other.GetComponentInChildren<ParticleSystem>().Stop();

			// Check if player hit all targets
			if (other.GetComponent<DrillControls>().win)
			{
				// Go to next level
				GameObject.Find("Main Camera").GetComponent<FadeOut>().fade = true;
			}
			else
			{
				// Reload level
				GameObject.Find("Main Camera").GetComponent<FadeOut>().nextScene = Application.loadedLevelName;
				GameObject.Find("Main Camera").GetComponent<FadeOut>().fade = true;
			}
		}
	}
	
}
