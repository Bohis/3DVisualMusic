using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnColumn : MonoBehaviour {
	[SerializeField] GameObject ColumnPrefab;
	public GameObject [] ColumnArray;
	// Start is called before the first frame update
	void Start ( ) {
		ColumnArray = new GameObject [ 32 ];
		float d = 360 / 32f;

		Vector3 center = transform.position;
		for ( int i = 0; i < ColumnArray.Length; i++ ) {
			Vector3 pos = RandomCircle ( center, 12f , i * d);
			ColumnArray [i] = Instantiate ( ColumnPrefab, pos, new Quaternion(0,0,0,0) );
		}
	}

	// Update is called once per frame
	void Update ( ) {

	}

	Vector3 RandomCircle ( Vector3 center, float radius, float index ) {
		float ang = index;
		Vector3 pos;
		pos.x = center.x + radius * Mathf.Sin ( ang * Mathf.Deg2Rad );
		pos.y = 0;
		pos.z = center.z + radius * Mathf.Cos ( ang * Mathf.Deg2Rad );
		return pos;
	}
}