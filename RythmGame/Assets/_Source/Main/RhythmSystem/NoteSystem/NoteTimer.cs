using System;
using System.Collections.Generic;
using UnityEngine;

public class NoteTimer : MonoBehaviour
{
    [Serializable]
    public class Note
    {
        public GameObject note;
        public float time;
    }
    [SerializeField] List<Note> _noteList = new List<Note>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (var note in _noteList)
        {
            if (note.time > 0)
            {
                note.time -= Time.deltaTime;
            }
            else
            {
                Instantiate(note.note);
                note.note.SetActive(true);
                _noteList.Remove(note);
            }
        }
    }
}
