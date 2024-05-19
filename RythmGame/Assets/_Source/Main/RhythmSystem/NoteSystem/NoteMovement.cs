using UnityEngine;

namespace NoteSystem
{
    public class NoteMovement
    {
        public void Move(GameObject note, float speed)
        {
            note.transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}


