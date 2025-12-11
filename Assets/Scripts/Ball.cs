using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Ball : MonoBehaviour
{
    /*public GameObject prefab;
    private float elapsedTime = 0f;

    private void CreateBall()
    {
        Instantiate(prefab);
    }

    
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            Createball(Vector3 position, Color color);
            elapsedTime = 0f;
        }

        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randomColor = new Color(r, g, b, 1f);

        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f)
        {
            Createball(randomColor);
            elapsedTime = 0f;
        }


    }

    private GameObject Createball(Vector3 position, Color color)
    {
        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        Material material = ball.GetComponent<Renderer>().material;
        if (material.shader.name == "Universal Render Pipeline/Lit")
        {
            material.SetColor("_BaseColor", color);
        }
        else
        {
            material.color = color;
        }
        return ball;
    }
    */
}








