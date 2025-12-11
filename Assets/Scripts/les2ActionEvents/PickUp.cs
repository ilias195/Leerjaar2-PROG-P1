using System;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private string itemName = "PickUp";

    public static event Action<string> pickedUpItem;

    [SerializeField] private ScoreBoard scoreboard;
    [SerializeField] private int scoreValue = 50;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player picked up: " + itemName);
            Destroy(gameObject);


            pickedUpItem?.Invoke(itemName);
        }
        if (scoreboard != null)
        {
            scoreboard.AddScore(scoreValue);
        }

        // Verwijder het item
        Destroy(gameObject);
    }
}

