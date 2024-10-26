using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    [System.Serializable]
    public class NoteEntry
    {
        public float spawnTime;
    }

    [SerializeField] private List<NoteEntry> _noteList = new List<NoteEntry>();
    [SerializeField] private NotePool _notePool;

    private void Awake()
    {
        _notePool = new NotePool();
    }

    private void Update()
    {
        for (int i = 0; i < _noteList.Count; i++)
        {
            if (_noteList[i].spawnTime > 0)
            {
                _noteList[i].spawnTime -= Time.deltaTime;
            }
            else
            {
                SpawnNote();
                _noteList[i].spawnTime = float.MaxValue;
            }
        }
    }

    private void SpawnNote()
    {
        GameObject note = _notePool.GetNote();
        note.transform.position = new Vector3(Random.Range(-5f, 5f), 6f, 0f);
    }
}