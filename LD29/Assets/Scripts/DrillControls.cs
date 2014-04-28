using UnityEngine;
using System.Collections;

public class DrillControls : MonoBehaviour 
{
	public float rotationSpeed;

	public float drillSpeed = 0.1f;

	public bool drill = false;
	private bool lockRotation = false;
	
	public bool win = false;

	public int targetCount = 0;
	public int currentTargetCount = 0;

	private Vector3 movementDirection;

	public GameObject dirtTrailPrefab;

	// Use this for initialization
	void Start () 
	{
		targetCount = GameObject.FindGameObjectsWithTag("Target").Length;
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<Animator>().SetBool("Drill", drill);

		handleRotation();

		handleDrilling();

		if (currentTargetCount == targetCount)
		{
			win = true;
		}
	}

	void handleRotation()
	{
		Vector2 circleCenter = GameObject.Find("Circle").GetComponent<SpriteRenderer>().bounds.center;

		if (!drill)
		{
			transform.RotateAround(circleCenter, Vector3.forward, -Input.GetAxisRaw("Horizontal") * rotationSpeed);
		}
	}

	void handleDrilling()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			audio.Play();

			if (!drill)
			{
				// Move drill across circle
				drill = true;
				Vector3 dirtPosition = transform.position;

				//Vector3.MoveTowards(dirtPosition, -transform.up, 5);

				GameObject tempDirt = (GameObject) Instantiate(dirtTrailPrefab, dirtPosition, transform.rotation);
				tempDirt.transform.parent = transform;
			}


		}

		if (drill)
		{
			lockRotation = true;
			transform.Translate(Vector3.down * drillSpeed);

		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.CompareTag("Target") && drill)
		{

			// Handle enemy side
			other.GetComponent<ParticleSystem>().Emit(40);

			Color invisColor = other.GetComponent<SpriteRenderer>().color;
			invisColor.a = 0;

			// Make target disappear
			other.GetComponent<SpriteRenderer>().color = invisColor;

			// Disable all collisions
			other.GetComponent<Collider2D>().enabled = false;

			// Kill target sprite when ready (in target code)
			other.GetComponent<Target>().kill = true;

			// Disable trail renderer
			other.GetComponent<TrailRenderer>().enabled = false;

			// Add 1 to counter
			currentTargetCount++;
		}

		if (other.CompareTag("Reflection") && drill)
		{
			// Calculate reflection angle
			Vector3 normalVector = other.transform.up;
			Vector3 inDirectionVector = -transform.up;

			transform.up = -Vector3.Reflect(inDirectionVector, normalVector);

		}
	}

}
