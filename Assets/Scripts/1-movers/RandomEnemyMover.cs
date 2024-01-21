using System;
using UnityEngine;

public class RandomEnemyMover : MonoBehaviour
{
    [Tooltip("Random Movement vector in meters per second")]
    [SerializeField] float max_x;
    [SerializeField] float min_x;
    [SerializeField] float max_y;
    [SerializeField] float min_y;
    [SerializeField] float speed;
    private float x_movement;
    private float y_movement;
    private bool movingRight = true;
    private bool movingDown = true;
    public float width = 10f;
    public float height = 5f;

    void Update()
    {
        x_movement = UnityEngine.Random.Range(min_x, max_x);
        y_movement = UnityEngine.Random.Range(min_y, max_y);
        if (movingRight)
        {
            // Debug.Log(ToStrin)
            transform.position += new Vector3(Mathf.Lerp(0,x_movement* speed * Time.deltaTime,10f), 0, 0);
        }
        else
        {
            transform.position += new Vector3(Mathf.Lerp(0,-x_movement* speed * Time.deltaTime,10f), 0, 0);
        }
        if (movingDown)
        {
            transform.position += new Vector3(0, Mathf.Lerp(0,-y_movement* speed * Time.deltaTime,10f), 0);
        }
        else
        {   
            Mathf.Lerp(0,-x_movement* speed * Time.deltaTime,0);
            transform.position += new Vector3(0, Mathf.Lerp(0,y_movement* speed * Time.deltaTime,10f), 0) ;
        }

        // Check if the formation is going outside the playspace...
        float rightEdgeOfFormation = transform.position.x + (0.5f * width) * Time.deltaTime ;
        float leftEdgeOfFormation = transform.position.x - (0.5f * width) * Time.deltaTime;
        float topEdgeOfFormation = transform.position.y + (0.5f * height)* Time.deltaTime;
        float bottomEdgeOfFormation = transform.position.y - (0.5f * height)* Time.deltaTime;
        if (leftEdgeOfFormation < min_x || rightEdgeOfFormation > max_x)
        {
            movingRight = !movingRight;
        }
        if (bottomEdgeOfFormation < min_y || topEdgeOfFormation > max_y)
        {
            movingDown = !movingDown;
        }

        // transform.position += new Vector3(x_movement, 0, 0) * Time.deltaTime;
        // if(x_movement < 0)
        //     transform.localScale = new Vector3(-1 * transform.localScale.x, transform.localScale.y, transform.localScale.z);
        // else
        //     transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
}
