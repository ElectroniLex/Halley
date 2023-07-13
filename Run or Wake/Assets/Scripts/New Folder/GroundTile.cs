using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawn groundSpawn;


    private void Start()
    {
        groundSpawn = GameObject.FindObjectOfType<GroundSpawn>();
        SpawnObstacule();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawn.SpawnTile();
        Destroy(gameObject, 2);
    }

    private void Update()
    {

    }

    public GameObject obstaculePrefab;

    void SpawnObstacule()
    {
        int obstacleSpawn = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawn).transform;

        Instantiate(obstaculePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
