using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyPrefab;
    [SerializeField]
    private int NumberOfEnemy;
    [SerializeField]
    private float MinX;
    [SerializeField]
    private float MaxX;
    [SerializeField]
    private float MinZ;
    [SerializeField]
    private float MaxZ;

    public List<Vector3> list = new List<Vector3>();
    public List<GameObject> list2 = new List<GameObject>();

    void Start()
    {
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        Vector3 position = new Vector3(0f, 0f, 0f);
        Quaternion rotation = new Quaternion(0f, 0f, 0f, 0f);
        for (int i = 0; i < NumberOfEnemy; i++)
        {
            
            position.Set(Random.Range(MinX, MaxX), 1f, Random.Range(MinZ, MaxZ));
            list.Add(position);
            Debug.Log($"{list[i]}");
            list2.Add(Instantiate(EnemyPrefab, position, rotation));
        }
    }


}