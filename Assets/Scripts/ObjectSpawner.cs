using AG1922;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private List<GameObject> spawnedObjects = new List<GameObject>();

    void Start()
    {
        GameObject player = new GameObject("SpawnedPlayer");
        player.AddComponent<PlayerMovement>();
        spawnedObjects.Add(player);

        GameObject interactable = new GameObject("SpawnedInteractable");
        interactable.AddComponent<InteractionSystem>();
        spawnedObjects.Add(interactable);

        Debug.Log($"Spawned {spawnedObjects.Count} objects.");
    }
}
