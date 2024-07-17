using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChange : MonoBehaviour
{
    PlayerMovement _playerMovement;
    Animator2D _animator2D;

    [SerializeField] Texture2D[] _spritesheets;

    void Start()
    {
        _animator2D = GetComponent<Animator2D>();
        _playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (_playerMovement.sideRunning == true && _playerMovement.frontRunning == false && _playerMovement.backRunning == false) { _animator2D.ChangeSpritesheet(_spritesheets[0], 8, 10.0f); }

        else if (_playerMovement.sideRunning == true && _playerMovement.frontRunning == false && _playerMovement.backRunning == true || _playerMovement.backRunning == true) { _animator2D.ChangeSpritesheet(_spritesheets[1], 8, 10.0f); }

        else if (_playerMovement.sideRunning == true && _playerMovement.frontRunning == true && _playerMovement.backRunning == false || _playerMovement.frontRunning == true) { _animator2D.ChangeSpritesheet(_spritesheets[2], 8, 10.0f); }

        else { _animator2D.ChangeSpritesheet(_spritesheets[3], 8, 10.0f); }
    }
}
