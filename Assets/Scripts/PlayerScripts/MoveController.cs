using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : IPlayerController
{
    public float HorizontalAxis => Input.GetAxis("Horizontal") * Time.deltaTime;

    public float VerticalAxis => Input.GetAxis("Vertical") * Time.deltaTime;

    public float JumpAxis => Input.GetAxis("Jump");


    public void Horizontal(Transform _transform , float _hSpeed, bool _isHorizontalActive)
    {
        switch (_isHorizontalActive)
        {
            case true:
                _transform.position += new Vector3(Input.GetAxis("Horizontal") * _hSpeed * Time.deltaTime, 0);   
                    break;
            default:
                _isHorizontalActive = false;
                break;
        }
    }

    public void Flip(SpriteRenderer _spriteRenderer, bool _isFlipActive)
    {
        switch (_isFlipActive)
        {
            case true:
                if (HorizontalAxis < 0)
                {
                    _spriteRenderer.flipX = true;
                }
                else if (HorizontalAxis > 0)
                {
                    _spriteRenderer.flipX = false;
                }
                break;
            default:
                _isFlipActive = false;
                break;
        }
    }



}
