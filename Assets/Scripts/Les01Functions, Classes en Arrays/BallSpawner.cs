using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;

    private GameObject CreateBall(Color c, Vector3 position)
    {
       
        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        Material mat = ball.GetComponent<MeshRenderer>().material;

        if (mat.HasProperty("_BaseColor"))
        {
            mat.SetColor("_BaseColor", c);
        }
        return ball;
    }
    private void DestroyBall(GameObject ball)
    {
        Destroy(ball, 3f);
    }
    private void Start()
    {
        
        for (int i = 0; i < 100; i++)
        {
            Color randColor = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                1f
            );

            Vector3 randPosition = new Vector3(
                Random.Range(-5f, 5f),
                Random.Range(5f, 8f),
                Random.Range(-5f, 5f)
            );

            GameObject ball = CreateBall(randColor, randPosition);
            DestroyBall(ball);
        }
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f)
        {
            Color randColor = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                1f
            );

            Vector3 randPosition = new Vector3(
                Random.Range(-5f, 5f),
                Random.Range(5f, 8f),
                Random.Range(-5f, 5f)
            );

            GameObject ball = CreateBall(randColor, randPosition);
            DestroyBall(ball);

            elapsedTime = 0f;
        }
    }

}
   
