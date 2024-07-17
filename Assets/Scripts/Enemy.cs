using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public Transform _playerPosition;
    [SerializeField] public Transform[] _movementPoints;

    public float patrolSpeed;
    public float chaseSpeed;

    VisionDetector _visionDetector;

    public bool rotate = false; 

    Vector3 _initialPoint;
    public Vector2 _directionEnemy;

    Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _initialPoint = transform.position;      
        _visionDetector = GetComponent<VisionDetector>();
    }

    void Update()
    {
        _animator.SetBool("Detected", _visionDetector.detected);

        if (PlayerCaught.caughtPlayer)
        {
            transform.position = _initialPoint;
        }

        if (rotate == true)
        {
            Flip();
            rotate = false;
        }
    }

    public void Flip()
    {
        transform.Rotate(0, 180, 0);
    }
}
