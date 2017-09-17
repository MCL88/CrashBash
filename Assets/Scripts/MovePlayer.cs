using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

	public float speed = 3f;
	private Transform _transform;
	private Vector3 position;

	// Use this for initialization
	void Start () {
		_transform = transform;
		position = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
	
		_transform.Translate(Input.GetAxisRaw("Horizontal")*speed*Time.deltaTime,0,0);
	}
}
