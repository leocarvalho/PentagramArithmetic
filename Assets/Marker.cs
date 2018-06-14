using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour {
	public Pentagram pentagram;
	private Vector3 screenPoint;
    private Vector3 offset;

	public TargetDigit target;

	public int level;

	bool moving = false;

	public int value{
		get{
			return target.digit;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(moving){

		}else{
			Vector3 pos = target.transform.position;
			pos.z = level - 3;
			transform.position = pos;
		}
	}

	void OnMouseDown() {
		moving = true;
 		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}

	void OnMouseDrag()
	{
		moving = true;
    	Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
    	Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
    	transform.position = curPosition;
	}

	void OnMouseUp() {
		moving = false;
		float minDist = Vector2.Distance(transform.position, target.transform.position);
		int currDigit = target.digit;
		foreach (var d in pentagram.digits)
		{
			float dist = Vector2.Distance(transform.position, d.transform.position);
			if(dist < minDist){
				minDist = dist;
				target = d;
			}
		}

		if(target.digit < currDigit)
			carry();
	}

	void carry(){
		Debug.Log("carry!");
	}
}
