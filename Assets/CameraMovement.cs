using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    //[Range(1,10)]
    //public float smoothFactor;

    private void FixedUpdate()
    {
        Vector3 cameraPosition = player.position + offset;
        //cameraPosition = Vector3.Lerp(transform.position, cameraPosition, smoothFactor*Time.fixedDeltaTime);
        transform.position = cameraPosition; 
    }
}
