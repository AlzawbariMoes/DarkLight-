using UnityEngine;
using System.Collections;

public class BGMover : MonoBehaviour {


	float speed = -2f;
	void FixUpdate()
	{
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
		
	}
}
