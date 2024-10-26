using UnityEngine;

namespace NoteSystemNew
{
    public class Note : MonoBehaviour, INote
    {
        [SerializeField] private float _speed;
        [SerializeField] NotePool pool;

        public void Move(float speed)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        public void OnTap()
        {
            ReturnToPool();
        }

        private void ReturnToPool()
        {
            if (pool != null)
            {
                pool.ReturnNote(gameObject);
            }
        }

        public float GetSpeed()
        {
            return _speed;
        }
    }
}