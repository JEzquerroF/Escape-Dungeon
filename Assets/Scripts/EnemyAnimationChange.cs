using UnityEngine;

public class EnemyAnimationChange : MonoBehaviour
{
    Enemy _enemyMovement;
    Animator2D _animator2D;

    [SerializeField] Texture2D[] _spritesheets;

    void Start()
    {
        _animator2D = GetComponent<Animator2D>();
        _enemyMovement = GetComponent<Enemy>();
    }

    void Update()
    {
        if (_enemyMovement._directionEnemy.y < 0) { _animator2D.ChangeSpritesheet(_spritesheets[0], 4, 10); }

        else { _animator2D.ChangeSpritesheet(_spritesheets[1], 4, 10); }
    }
}
