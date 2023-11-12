using UnityEngine;

public class IceMovement : MonoBehaviour
{
    public float moveSpeed = 2f;   // Horizontal movement speed
    public float floatSpeed = 0.5f; // Vertical floating speed
    public float floatHeight = 0.1f; // Vertical floating height
    public float horizontalRange = 1.5f; // Horizontal movement range

    private float originalY;
    private float originalX;
    private float startTimeOffset;
    private int direction;

    void Start()
    {
        originalY = transform.position.y;
        originalX = transform.position.x;

        // Use a unique seed based on the object's position
        int seed = Mathf.FloorToInt(originalX + originalY);
        Random.InitState(seed);

        startTimeOffset = Random.Range(0f, 2f * Mathf.PI); // Random start time offset
        direction = Random.Range(0, 2) == 0 ? 1 : -1; // Random direction (1 for right, -1 for left)
    }

    void Update()
    {
        // Move back and forth horizontally
        float horizontalMovement = originalX + Mathf.Sin((Time.time + startTimeOffset) * moveSpeed) * horizontalRange * direction;
        transform.position = new Vector3(horizontalMovement, transform.position.y, 0f);

        // Float vertically
        float verticalMovement = originalY + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(transform.position.x, verticalMovement, 0f);
    }
}
