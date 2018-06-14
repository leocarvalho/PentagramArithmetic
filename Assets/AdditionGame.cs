using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionGame : MonoBehaviour {
	public Pentagram pentagram;

	public int min;
	public int max;

	int sum;

	public bool check{ 
		get { return pentagram.value == sum; }
	}

	int _choice;
	public int choice{
		get{ return _choice; }
	}

	// Use this for initialization
	void Start () {
		reset();
		StartCoroutine("gameChecker");
	}
	
	// Update is called once per frame
	IEnumerator gameChecker () {
		while(true){
			if(check){
				yield return new WaitForSeconds(.5f);
				run();
			}else{
				yield return null;
			}
		}

		yield return null;
	}

	public void reset(){
		sum = 0;
		pentagram.reset();

		run();
	}

	void run(){
		_choice = Random.Range(min, max);
		sum += _choice;
	}
}
