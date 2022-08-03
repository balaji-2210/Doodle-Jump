using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject stillTile;
    public GameObject movingTile;
    public GameObject boostTile;
    public GameObject finish;

    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = 0.3f;
    public float maxY = 2f;
    public float probOfMoving = 0.7f;
    public float probOfBoost = 0.9f;

    void Start()
    {
        Vector2 spawnPosition = new Vector2();
        
        for(int i=0; i < numberOfPlatforms; i++)
        {
            if (Random.Range(0f, 1f) > probOfMoving)
            {
                spawnPosition.y += Random.Range(minY, maxY);
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                Instantiate(movingTile, spawnPosition, Quaternion.identity);
            }
            else if (Random.Range(0f, 1f) > probOfBoost)
            {
                spawnPosition.y += Random.Range(minY, maxY);
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                Instantiate(boostTile, spawnPosition, Quaternion.identity);
            }
            else
            {
                spawnPosition.y += Random.Range(minY, maxY);
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                Instantiate(stillTile, spawnPosition, Quaternion.identity);
            }
        }
        spawnPosition.y += Random.Range(minY, maxY);
        spawnPosition.x = Random.Range(-levelWidth, levelWidth);
        Instantiate(boostTile, spawnPosition, Quaternion.identity);

        spawnPosition.y += 10f;
        spawnPosition.x = 0f;
        Instantiate(finish, spawnPosition, Quaternion.identity);
    }
}
