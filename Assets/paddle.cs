using UnityEngine;

public class paddle : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;

    public float speed = 1.7f;
    public float maxY = 1.11f;
    public float minY = -1.11f;

    private Rigidbody2D leftPaddle;

    // Start is called before the first frame update
    void Start()
    {
        leftPaddle = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        var velocity = leftPaddle.velocity;
        if (Input.GetKey(moveUp))
        {
            velocity.y = -speed;
        }
        else if (Input.GetKey(moveDown))
        {
            velocity.y = speed;
        }
        else
        {
            velocity.y = 0;
        }
        leftPaddle.velocity = velocity;

        // to avoid the paddle goes out of our view point
        var position = transform.position;
        if (position.y >= maxY)
        {

            position.y = maxY;

        }
        else if (position.y <= minY)
        {
            position.y = minY;
        }
        transform.position = position;
    }
}
