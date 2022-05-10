using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    MoveController _moveController;
    [SerializeField] Transform _playerTransform;
    [SerializeField] float _hSpeed;
    [SerializeField] bool _isHorizontalActive , _isFlipActive;
    [SerializeField] Animator _animator;
    [SerializeField] SpriteRenderer _playerSpriteRenderer;

    private void Awake()
    {
        _moveController = new MoveController();
    }
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        Walk();
        Flip();
    }

    void Update()
    {
        
    }

    void Walk()
    {
        _moveController.Horizontal(_playerTransform, _hSpeed, _isHorizontalActive);
        _animator.SetFloat("__isWalk", Mathf.Abs(Input.GetAxis("Horizontal")));
    }

    void Flip()
    {
        _moveController.Flip(_playerSpriteRenderer, _isFlipActive);
    }
}
