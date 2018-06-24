using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dreamer : MonoBehaviour {

	private Collider2D myCollider;

	public Text dreamText;

	// Use this for initialization
	void Start () {
		myCollider = GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		DreamTextAppear ();
	}

	void DreamTextAppear () {
		if (myCollider.IsTouchingLayers (LayerMask.GetMask ("Player"))) {
			dreamText.enabled = true;
			print ("Can dream");
		} else {
			dreamText.enabled = false;
		}
	}
}
