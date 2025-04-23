using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rbPlayer;
    public float verticalMovement;
    public float speed = 10f;
    private GameObject focalPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        verticalMovement = Input.GetAxis("Vertical");
        rbPlayer.AddForce(focalPoint.transform.forward * verticalMovement * speed);
        
    }
}
