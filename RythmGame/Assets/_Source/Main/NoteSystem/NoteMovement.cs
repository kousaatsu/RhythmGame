using System;
using UnityEngine;

namespace NoteSystemNew
{
    public class NoteMovement : MonoBehaviour
    {
        INote _note;

        private void Start()
        {
            _note = GetComponent<INote>();
        }

        private void Update()
        {
            _note.Move(_note.GetSpeed());
        }
    }
}
