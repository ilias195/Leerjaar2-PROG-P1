using UnityEngine;
using UnityEngine.UIElements;

public class TowerSpawner : MonoBehaviour
{
    public GameObject towerPrefab;
    private GameObject CreateTower(Vector3 position)
    {
       
        GameObject tower = Instantiate(towerPrefab, position, Quaternion.identity);

       

        return tower;
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 spawnPosition = new Vector3
                (
                Random.Range(-5f, 5f), 
                 0f,
                Random.Range(-5f, 5f)
            );
            GameObject tower = CreateTower(spawnPosition);

            float scaleX = Random.Range(0.5f, 2f);
            float scaleY = Random.Range(1f, 3f);
            float scaleZ = Random.Range(0.5f, 2f);

            tower.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        }

    }
}
