using System;
using UnityEngine;

public class HeroControls : MonoBehaviour {

	Vector3 MoveVector;                          // For movement
  float speed = 10.0f;                         // Speed of movement

  void Start () {
      MoveVector = transform.position;          // Take the initial position
  }

  void FixedUpdate () {

     if(Input.GetKey(KeyCode.LeftArrow) && transform.position == MoveVector) {     // Left
				Vector3 VecLeft = new Vector3(-1.28f, 0, 0);
        MoveVector += VecLeft;
      }
     if(Input.GetKey(KeyCode.RightArrow) && transform.position == MoveVector) {    // Right
				Vector3 VecRight = new Vector3(1.28f, 0, 0);
        MoveVector += VecRight;
      }
     if(Input.GetKey(KeyCode.UpArrow) && transform.position == MoveVector) {       // Up
				Vector3 VecUp = new Vector3(0, 1.28f, 0);
        MoveVector += VecUp;
      }
     if(Input.GetKey(KeyCode.DownArrow) && transform.position == MoveVector) {     // Down
		 		Vector3 VecDown = new Vector3(0, -1.28f, 0);
        MoveVector += VecDown;
      }
      transform.position = Vector3.MoveTowards(transform.position, MoveVector, Time.deltaTime * speed);    // Move there

  }
}
