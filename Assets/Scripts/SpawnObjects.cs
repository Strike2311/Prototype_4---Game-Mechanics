using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;
    public float spawnLimitMin = -8f;
    public float spawnLimitMax = 8f;
    public int enemiesOnMapLimit = 1;
    public int powerUpSpawnInterval = 15;

    private Vector3 spawnLocation;
    private float powerupSpawnTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0) {
            for (int i = 0; i < enemiesOnMapLimit; i++) {
                spawnLocation = GenerateNewSpawnLocation();
                Instantiate(enemyPrefab, spawnLocation, transform.rotation);
            }
            enemiesOnMapLimit++;
        }
        if (Time.time - powerupSpawnTimer > powerUpSpawnInterval) {
            spawnLocation = GenerateNewSpawnLocation();
            Instantiate(powerUpPrefab, spawnLocation, transform.rotation);
            powerupSpawnTimer = Time.time;
        }
        
    }
    Vector3 GenerateNewSpawnLocation() {
        return new Vector3(Random.Range(spawnLimitMin, spawnLimitMax), 0.01f, Random.Range(spawnLimitMin, spawnLimitMax));
    }
}
