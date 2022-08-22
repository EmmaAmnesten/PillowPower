using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{

	private Rigidbody2D playerRigidbody;
	public float runPower;
	public float jumpPower;
	public float maxSpeed;
	public float jumpVelocity;

	//private bool isGrounded = true;

	private BoxCollider2D hitBox;

	private void Awake(){
		playerRigidbody = GetComponent<Rigidbody2D>();
		hitBox = transform.GetComponent<BoxCollider2D>();
	}

	public void Move(float xInput, float yInput)
	{


		//if (isGrounded && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)))
		//{
		//	Debug.Log("Move");
		//	IsGrounded2();
		//	//playerRigidbody.AddForce(new Vector2(0, yInput * jumpPower));
		//	playerRigidbody.velocity = Vector2.up * jumpVelocity;
		//	isGrounded = false;
		//	Debug.Log("Move: isGrounded=" + isGrounded);
		//}


		if (playerRigidbody.velocity.x > (-1)*maxSpeed && 
			playerRigidbody.velocity.x < maxSpeed)
		{
			playerRigidbody.AddForce(new Vector2(xInput * runPower, 0));
		}
	}

	private void IsGrounded2()
	{
		Debug.Log("IsGrounded2: hitbox: " + BoundsToString(hitBox.bounds));
		RaycastHit2D raycastHit2D = Physics2D.BoxCast(hitBox.bounds.center, hitBox.bounds.size, 0f, Vector2.down, 3*hitBox.bounds.extents.y, 6);
		Debug.Log(raycastHit2D.collider);
	}

	private string Vector3ToString(Vector3 vector3)
	{
		return "(" + vector3.x + ", " + vector3.y + ", " + vector3.z + ")";
	}

	private string BoundsToString(Bounds bounds)
	{
		return "(" +
			(bounds.center.x - bounds.extents.x) + ":" + (bounds.center.x + bounds.extents.x) + ", " +
			(bounds.center.y - bounds.extents.y) + ":" + (bounds.center.y + bounds.extents.y) + ", " +
			(bounds.center.z - bounds.extents.z) + ":" + (bounds.center.z + bounds.extents.z) +
			") + [" + bounds.size.x + ", " + bounds.size.y + ", " + bounds.size.z + "]";
	}


	//private void OnCollisionStay2D(Collision2D col)
	//{
	//	float colx = col.gameObject.GetComponent<BoxCollider2D>().bounds.size.x;
	//	float coly = col.gameObject.GetComponent<BoxCollider2D>().bounds.size.y;
	//	float colz = col.gameObject.GetComponent<BoxCollider2D>().bounds.size.z;
	//	float plx = playerRigidbody.gameObject.GetComponent<BoxCollider2D>().bounds.size.x;
	//	float ply = playerRigidbody.gameObject.GetComponent<BoxCollider2D>().bounds.size.y;
	//	float plz = playerRigidbody.gameObject.GetComponent<BoxCollider2D>().bounds.size.z;
	//
	//	//Debug.Log("OnCollisionStay2D: col: (" + colx + ", " + coly + ", " + colz + ")");
	//	//Debug.Log("OnCollisionStay2D: pl: (" + plx + ", " + ply + ", " + plz + ")");
	//
	//	if (col.gameObject.layer == 6 && playerRigidbody.velocity.y < 0.0001)
    //    {
	//		isGrounded = true;
    //    }
	//
	//	//Debug.Log("OnCollisionStay2D: playerRigidbody.velocity.y= " + playerRigidbody.velocity.y);
	//	//Debug.Log("OnCollisionStay2D: col.gameObject.layer= " + col.gameObject.layer);
	//	//Debug.Log("OnCollisionStay2D: isGrounded=" + isGrounded);
	//}
}
