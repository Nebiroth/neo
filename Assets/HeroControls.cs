using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControls : MonoBehaviour {

	Vector3 pos;                                // For movement
  float speed = 2.0f;                         // Speed of movement

  void Start () {
      pos = transform.position;          // Take the initial position
  }

  void FixedUpdate () {
      if(Input.GetKey(KeyCode.A) && transform.position == pos) {        // Left
					Vector3 VecLeft = new Vector3(-1.28f, 0, 0);
          pos += VecLeft;
      }
      if(Input.GetKey(KeyCode.D) && transform.position == pos) {        // Right
					Vector3 VecRight = new Vector3(1.28f, 0, 0);
          pos += VecRight;
      }
      if(Input.GetKey(KeyCode.W) && transform.position == pos) {        // Up
					Vector3 VecUp = new Vector3(0, 1.28f, 0);
          pos += VecUp;
      }
      if(Input.GetKey(KeyCode.S) && transform.position == pos) {        // Down
					Vector3 VecDown = new Vector3(0, -1.28f, 0);
          pos += VecDown;
      }
      transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there
  }
}
