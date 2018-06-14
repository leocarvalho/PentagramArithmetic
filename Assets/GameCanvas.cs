using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCanvas : MonoBehaviour {
	public Text text;
	public AdditionGame game;
	
	// Update is called once per frame
	void Update () {
		if(game.check){
			text.text = "OK!";
		}else{
			text.text = game.choice.ToString();
		}
	}
}
