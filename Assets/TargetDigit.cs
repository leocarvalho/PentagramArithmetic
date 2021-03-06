﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TargetDigit : MonoBehaviour {
	[Range(0, 9)]
	public int digit = 0;
	public PenthagonParams Params;
	float gr = 1.61803398875f;

	// Update is called once per frame
	void Update () {
		float dt = 2*Mathf.PI/5;
		float t = 0.0f;
		float s = 1.0f;

		if(digit%2 == 0){
			t = digit/2*dt;
			s = Params.radio;
		}else{
			t = (digit+5)/2*dt + Mathf.PI;
			s = gr*Params.radio/4;
		}

		transform.localPosition = new Vector2(s*Mathf.Sin(t), s*Mathf.Cos(t));
	}
}
