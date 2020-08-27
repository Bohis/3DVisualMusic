using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioData : MonoBehaviour {

	private float[] _dataColumn;
	private int _size;

	// Start is called before the first frame update
	void Start ( ) {
		_size = 64;
		_dataColumn = new float [_size];
	}

	// Update is called once per frame
	void Update ( ) {
		GetDataMusic ( );
	}

	private void GetDataMusic ( ) {
		AudioListener.GetSpectrumData (_dataColumn,0,FFTWindow.Rectangular );
	}

	public float [] DataArray { get => _dataColumn; }
}