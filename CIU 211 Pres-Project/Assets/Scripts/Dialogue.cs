using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dialogue : MonoBehaviour {

	public GameObject[] text;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void clicked()
	{
		foreach (GameObject hello in text) 
		{
			hello.SetActive (false);
		}
	}
}
