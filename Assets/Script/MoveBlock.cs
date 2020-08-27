using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour {

	// Start is called before the first frame update
	void Start ( ) {

	}

	// Update is called once per frame
	void Update ( ) {
		float [] array = ArrayCompress(GameObject.FindGameObjectsWithTag ( "MainCamera" ) [ 0 ].GetComponent<AudioData> ( ).DataArray);

		GameObject [] objArray = GameObject.FindGameObjectsWithTag ( "MainCamera" ) [ 0 ].GetComponent<SpawnColumn> ( ).ColumnArray;

		float max = 0;

		for ( int k = 0; k < array.Length; k++ ) {
			if ( max < array [ k ] ) {
				max = array [ k ];
			}
		}

		for ( int k = 0; k < array.Length; k++ ) {
			array [ k ] = ( array [ k ] / max ) * 10;
			
			Vector3 posit = new Vector3 ( objArray [ k ].transform.position.x, array [ k ] / 2f, objArray [ k ].transform.position.z );
			objArray [ k ].transform.position = posit;
			objArray [ k ].transform.localScale = new Vector3 ( objArray [ k ].transform.localScale.x, array [ k ], objArray [ k ].transform.localScale.z );
		}
	}

	float [] ArrayCompress (float[] array ) {
		float [] arrayCompress = new float [ array.Length / 2 ];

		for ( int i = 0, j = 0; i < arrayCompress.Length; ++i, j+=2 ) {
			arrayCompress [ i ] = ( array [ j ] + array [ j + 1 ] ) / 2f;
		}

		return arrayCompress;
	}
}