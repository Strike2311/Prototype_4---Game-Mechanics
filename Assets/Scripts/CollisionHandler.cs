using System.Collections;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{   
    private GameObject powerUpRing;
    private float powerUpTimer;
    public float powerUpTimeLimit = 15f;
    public float powerUpForce = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        powerUpRing = GameObject.Find("PowerUpRing");
    }

    // Update is called once per frame
    void Update()
    {
        if (powerUpRing.activeSelf && Time.time - powerUpTimer > powerUpTimeLimit) {
            powerUpRing.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Powerup")) {
            StartCoroutine(PowerupCountdownRoutine());
            Destroy(other.gameObject);
        } else {

            if (powerUpRing.activeSelf) {
                Rigidbody enemyRigidbody = other.GetComponent<Rigidbody>();
                enemyRigidbody.linearVelocity = enemyRigidbody.linearVelocity.normalized * powerUpForce;
                powerUpRing.SetActive(false);
            }
        }
    }

    IEnumerator PowerupCountdownRoutine() {
        yield return new WaitForSeconds(10);
        powerUpRing.SetActive(false);

    }
}
