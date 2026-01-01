using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using NUnit.Framework;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefab;
    private float _timer = 0f;


    private List<GameObject> enmies = new List<GameObject>();

    void SpawnEnmey()
    {
        GameObject enemy = Instantiate(prefab, transform.position, Quaternion.identity);
        enmies.Add(enemy);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                SpawnEnmey();
            }

        }
        _timer += Time.deltaTime;
        if (_timer >= 3f)
        {
            for (int i = 0; i < 3; i++)
            {
                SpawnEnmey();
            }

            _timer = 0f;
        }

        // Destroy all enemies met Q
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < enmies.Count; i++)
            {
                Destroy(enmies[i]);
            }

            enmies.Clear();
            

        }
    }
}

