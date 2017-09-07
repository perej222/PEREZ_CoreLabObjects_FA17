using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//declare a variable for speed

public class MoveFiveUnitsFromX : MonoBehaviour {

	//delare variable
	public float MoveSpeedFloatBox;
	public float RotateSpeedFloatBoxs;


	//Initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {
		float MOVE = Input.GetAxisRaw ("Horizontal") * MoveSpeedFloatBox ;
		float ROTATE = Input.GetAxisRaw ("Vertical") * RotateSpeedFloatBoxs;
		transform.Rotate (ROTATE, 0, 0);
		transform.Translate (MOVE, 0, 0);

	}
}