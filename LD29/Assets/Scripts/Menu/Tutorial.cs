using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour 
{
	private float _alpha = 1;
	private bool fadeAlpha = false;

	private bool wKey;
	private bool aKey;
	private bool sKey;
	private bool dKey;
	private bool spaceKey;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			GameObject.Find("WKey").GetComponent<GUIText>().color = new 
				Color(GameObject.Find("WKey").GetComponent<GUIText>().color.r, GameObject.Find("WKey").GetComponent<GUIText>().color.g, 
				      GameObject.Find("WKey").GetComponent<GUIText>().color.b, 0);

			GameObject.Find("WLetter").GetComponent<GUIText>().color = new 
				Color(GameObject.Find("WLetter").GetComponent<GUIText>().color.r, GameObject.Find("WLetter").GetComponent<GUIText>().color.g, 
				      GameObject.Find("WLetter").GetComponent<GUIText>().color.b, 0);

			wKey = true;

		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			GameObject.Find("AKey").GetComponent<GUIText>().color = new 
				Color(GameObject.Find("AKey").GetComponent<GUIText>().color.r, GameObject.Find("AKey").GetComponent<GUIText>().color.g, 
				      GameObject.Find("AKey").GetComponent<GUIText>().color.b, 0);
			
			GameObject.Find("ALetter").GetComponent<GUIText>().color = new 
				Color(GameObject.Find("ALetter").GetComponent<GUIText>().color.r, GameObject.Find("ALetter").GetComponent<GUIText>().color.g, 
				      GameObject.Find("ALetter").GetComponent<GUIText>().color.b, 0);

			aKey = true;
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			GameObject.Find("SKey").GetComponent<GUIText>().color = new 
				Color(GameObject.Find("SKey").GetComponent<GUIText>().color.r, GameObject.Find("SKey").GetComponent<GUIText>().color.g, 
				      GameObject.Find("SKey").GetComponent<GUIText>().color.b, 0);
			
			GameObject.Find("SLetter").GetComponent<GUIText>().color = new 
				Color(GameObject.Find("SLetter").GetComponent<GUIText>().color.r, GameObject.Find("SLetter").GetComponent<GUIText>().color.g, 
				      GameObject.Find("SLetter").GetComponent<GUIText>().color.b, 0);

			sKey = true;
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			GameObject.Find("DKey").GetComponent<GUIText>().color = new 
				Color(GameObject.Find("DKey").GetComponent<GUIText>().color.r, GameObject.Find("DKey").GetComponent<GUIText>().color.g, 
				      GameObject.Find("DKey").GetComponent<GUIText>().color.b, 0);
			
			GameObject.Find("DLetter").GetComponent<GUIText>().color = new 
				Color(GameObject.Find("DLetter").GetComponent<GUIText>().color.r, GameObject.Find("DLetter").GetComponent<GUIText>().color.g, 
				      GameObject.Find("DLetter").GetComponent<GUIText>().color.b, 0);

			dKey = true;
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject.Find("SpaceKey").GetComponent<GUIText>().color = new 
				Color(GameObject.Find("SpaceKey").GetComponent<GUIText>().color.r, GameObject.Find("SpaceKey").GetComponent<GUIText>().color.g, 
				      GameObject.Find("SpaceKey").GetComponent<GUIText>().color.b, 0);
			
			GameObject.Find("SpaceWord").GetComponent<GUIText>().color = new 
				Color(GameObject.Find("SpaceWord").GetComponent<GUIText>().color.r, GameObject.Find("SpaceWord").GetComponent<GUIText>().color.g, 
				      GameObject.Find("SpaceWord").GetComponent<GUIText>().color.b, 0);

			spaceKey = true;
		}

		if (wKey && aKey && sKey && dKey && spaceKey)
		{
			GetComponent<FadeOut>().fade = true;
		}
	}

}
