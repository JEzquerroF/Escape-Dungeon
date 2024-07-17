using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalMovement;
    float verticalMovement;
    [SerializeField] float speed;

    public static Transform _playerTransform;
    public static Rigidbody2D _rigidBodyPlayer;
    Vector2 _normalizedVelocity;

    public bool sideRunning = false;
    public bool frontRunning = false;
    public bool backRunning = false;

    void Start()
    {
        _rigidBodyPlayer = GetComponent<Rigidbody2D>();
        _playerTransform = GetComponent<Transform>();
    }

    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");

        _normalizedVelocity = new Vector2(horizontalMovement, verticalMovement).normalized;
        _rigidBodyPlayer.velocity = _normalizedVelocity * speed;

        if (horizontalMovement != 0 && verticalMovement == 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(-horizontalMovement), 1, 1) * 0.75f;
            sideRunning = true;
        }
        else { sideRunning = false; }

        if (verticalMovement != 0)
        {
            if (verticalMovement > 0) { backRunning = true; }
            else { frontRunning = true; }
        }
        else
        {
            frontRunning = false;
            backRunning = false;
        }
    }
}
