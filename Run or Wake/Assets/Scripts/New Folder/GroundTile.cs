using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawn groundSpawn;


    private void Start()
    {
        groundSpawn = GameObject.FindObjectOfType<GroundSpawn>();
        SpawnObstacule();
        SpawnAlmuhada();
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

    public GameObject AlmuhadaPrefab;

    void SpawnAlmuhada()
    {
        int AlmuhadaToSpanw = 10;

        for (int i = 0; i < AlmuhadaToSpanw; i++)
        {
            GameObject temp = Instantiate(AlmuhadaPrefab, transform);
            temp.transform.position = GetRandomPointInCollider (GetComponent<Collider>());
        }

    }
    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)

            );

        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;

    }
}
