using UnityEngine;
using System.Collections;


private Vector3 MovingDirection = Vector3.up;

void Update () {
	gameObject.transform.Translate(MovingDirection * Time.smoothDeltaTime);

	if(gameObject.transform.position.y > 3){
		MovingDirection = Vector3.down;
	}else if (gameObject.transform.position.y < -3) {
		MovingDirection = Vector3.up;
	}
}