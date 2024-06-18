using UnityEngine;

namespace NoteSystem
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Note : MonoBehaviour
    {
        [field: SerializeField] float _speed;
        [field: SerializeField] float _timer;

        NoteMovement _move;
        private void Start()
        {
            _move = new NoteMovement();
        }
        private void Update()
        {
            _move.Move(gameObject, _speed);
        }

    }

}
