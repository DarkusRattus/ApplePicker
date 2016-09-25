using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour
{


    public GameObject applePrefab; // Prefab for Apple instantiation
    public float speed = 1f; // Speed at which the AppleTree moves in meters/second
    public float leftAndRightEdge = 10f; // Distance where AppleTree turns around
    public float chanceToChangeDirection = 0.1f; // Chance that the AppleTree will change directions
    public float secondsBetweenAppleDrops = 1f; // Rate at which Apples will be intantiated

    void Start()
    {
        // Dropping Apples every second
    }

    void Update()
    {
        // Basic movement
        // Changing direction
    }

}
