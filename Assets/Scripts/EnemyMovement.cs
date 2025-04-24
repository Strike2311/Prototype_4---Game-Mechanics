using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody enemyRigidbody;
    private GameObject player;
    public float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 1 && transform.position.y > 0) {
            enemyRigidbody.AddForce((player.transform.position - transform.position).normalized * speed);
        }
    }
}
