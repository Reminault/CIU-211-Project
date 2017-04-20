using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour {

	public GameObject initialDialogue;
	public GameObject Yes1;
	public GameObject No1;

	bool activeTrigger;

	// Use this for initialization
	void Start () 
	{
		activeTrigger = true;
	}

	void OnTriggerEnter(Collider other)
	{
		if (activeTrigger == true) {
			
			if (other.tag == "Player") {
				initialDialogue.SetActive (true);
				Yes1.SetActive (true);
				No1.SetActive (true);
				activeTrigger = false;
			}
		}
	}
}
