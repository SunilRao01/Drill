using UnityEngine;
using System.Collections;

public class BGMusic : MonoBehaviour {
	public string endSongOnScene;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Application.loadedLevelName != endSongOnScene)
		{
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}
}
