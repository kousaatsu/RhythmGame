using CharacterSystem;
using UnityEngine;


namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] Character _character;
        [SerializeField] Camera _camera;
        [SerializeField] Rigidbody2D _characterrb;
        CharacterInvoker _invoker;
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";

        private void Awake()
        {
            _invoker = new CharacterInvoker(_character);
        }

        private void FixedUpdate()
        {
            ReadMove();
        }

        private void ReadMove()
        {
            float horizontal = Input.GetAxis(Horizontal);
            float vertical = Input.GetAxis(Vertical);
            Vector2 moveDir = new Vector2(horizontal, vertical);
            _invoker.Move(moveDir);
        }
    }
}

