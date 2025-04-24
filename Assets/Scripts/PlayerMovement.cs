using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rbPlayer;
    public float verticalMovement;
    public float speed = 10f;
    private GameObject focalPoint;
    private GameObject powerUpRing;
    private Quaternion powerUpRingRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
        powerUpRing = GameObject.Find("PowerUpRing");
        powerUpRingRotation = powerUpRing.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        verticalMovement = Input.GetAxis("Vertical");
        rbPlayer.AddForce(focalPoint.transform.forward * verticalMovement * speed);
        powerUpRing.transform.rotation = powerUpRingRotation;
        
    }
}
