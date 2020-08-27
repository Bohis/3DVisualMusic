using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Music : MonoBehaviour {
	[SerializeField] AudioClip MainSound;
	// Start is called before the first frame update
	void Start ( ) {
		AudioSource.PlayClipAtPoint ( MainSound, this.gameObject.transform.position );
	}

	// Update is called once per frame
	void Update ( ) {

	}
}