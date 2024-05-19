using CharacterSystem;
using System;
using UnityEngine;


namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] Character _character;
        [SerializeField] Camera _camera;
        [SerializeField] Rigidbody2D _characterrb;
        CharacterInvoker _invoker;
        private float Horizontal;
        bool _isFacingRight = true;
        Animator _animator;

        private void Awake()
        {
            _invoker = new CharacterInvoker(_character);
            _animator = _character.GetComponent<Animator>();
            _characterrb = _character.GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            ReadMove();
            _animator.SetFloat("xVelocity", Math.Abs(_characterrb.velocity.x) + Math.Abs(_characterrb.velocity.y));
        }

        private void ReadMove()
        {
            Horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector2 moveDir = new Vector2(Horizontal, vertical);
            FlipSprite();
            _invoker.Move(moveDir);
        }

        void FlipSprite()
        {
            if (_isFacingRight && Horizontal < 0f || !_isFacingRight && Horizontal > 0f)
            {
                _isFacingRight = !_isFacingRight;
                Vector3 ls = _character.transform.localScale;
                ls.x *= -1f;
                _character.transform.localScale = ls;
            }
        }
    }
}

