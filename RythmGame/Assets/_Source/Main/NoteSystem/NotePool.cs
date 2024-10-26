using System.Collections.Generic;
using UnityEngine;

public class NotePool : MonoBehaviour
{
    [SerializeField] private GameObject _notePrefab;
    [SerializeField] private int _poolSize = 10;

    private Queue<GameObject> _pool;

    private void Awake()
    {
        _pool = new Queue<GameObject>();

        for (int i = 0; i < _poolSize; i++)
        {
            GameObject note = Instantiate(_notePrefab);
            note.SetActive(false);
            _pool.Enqueue(note);
        }
    }

    public GameObject GetNote()
    {
        if (_pool.Count > 0)
        {
            GameObject note = _pool.Dequeue();
            note.SetActive(true);
            return note;
        }
        GameObject newNote = Instantiate(_notePrefab);
        return newNote;
    }

    public void ReturnNote(GameObject note)
    {
        note.SetActive(false);
        _pool.Enqueue(note);
    }
}