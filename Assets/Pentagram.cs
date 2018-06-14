using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pentagram : MonoBehaviour {
	public TargetDigit[] digits;

	public Marker[] markers;

	public int value{
		get{
			int v = 0;
			for(int i = 0; i < 3; ++i){
				v = v*10 + markers[i].value;
			}
			return v;
		}
	}

	public void reset(){
		markers[0].target = digits[0];
		markers[1].target = digits[0];
		markers[2].target = digits[0];
	}
}
