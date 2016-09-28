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
        InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrops);
    }

    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position; 
    }

    void Update()
    {
        // Basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        // Changing direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // Move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // Move left
        }
    }

    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirection)
        {
            speed *= -1; // Change direction
        }
    }
    
}
