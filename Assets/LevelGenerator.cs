using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public int numberOfObstacles = 10;
    public float spacing = 10f;
    public Transform player;

    void Start()
    {
        GenerateLevel();
    }

    void GenerateLevel()
    {
        for (int i = 0; i < numberOfObstacles; i++)
        {
            Vector3 position = new Vector3(Random.Range(-5f, 5f), 0.5f, i * spacing);
            Instantiate(obstaclePrefab, position, Quaternion.identity);
        }
    }
}

