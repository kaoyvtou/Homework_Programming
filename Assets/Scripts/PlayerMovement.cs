using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidBody2D;
    
    private float _xSpeed;
    private float _ySpeed;

    public float speed = 3;

    private string InputX = "Horizontal";
    private string InputY = "Vertical";

    private void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _xSpeed = Input.GetAxis(InputX);
        _ySpeed = Input.GetAxis(InputY);

        _rigidBody2D.velocity = new Vector2(_xSpeed, _ySpeed) * speed;
    }
}