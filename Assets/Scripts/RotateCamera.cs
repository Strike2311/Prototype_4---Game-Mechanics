using UnityEngine;

public class RotateCamera : MonoBehaviour
{

    public float rotationSpeed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.down * rotationSpeed * horizontalMovement * Time.deltaTime);
    }
}
