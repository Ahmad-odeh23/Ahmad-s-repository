using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour

{
    Vector3 playerInput;
	float playerSpeed = 10 ;
	void Update()
	{

		playerInput = new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical"));
		Vector3 direction = playerInput.normalized;
		Vector3 transformation = direction * playerSpeed * Time.deltaTime;

		transform.position += transformation ;
	}

}
