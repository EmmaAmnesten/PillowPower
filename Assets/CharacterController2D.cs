using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{

	private Rigidbody2D playerRigidbody;
	public float runPower;
	public float jumpPower;
	public bool isGrounded;

	private void Awake(){
		playerRigidbody = GetComponent<Rigidbody2D>();
		isGrounded = true;
	}

	public void Move(float xInput, float yInput){

		playerRigidbody.AddForce(new Vector2(xInput * runPower,0));
		
		if (isGrounded && yInput > 0){
			playerRigidbody.AddForce(new Vector2(0 , yInput * jumpPower));
		}

	}
}
