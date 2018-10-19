using UnityEngine;
using System.Collections;

public class player_animation : MonoBehaviour {

	Animator anim;

	void Start() {
		anim = GetComponent<Animator> ();

	}
	void FixedUpdate() {
	
		float move = Input.GetAxis("Horizontal");

		if (move == 0) anim.speed = 0;
		if (move != 0) anim.speed = 1;
	}
}
