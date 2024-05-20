using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

public class NoteTap : MonoBehaviour
{
    [field: SerializeField] KeyCode _key;
    [field: SerializeField] int _scoreVal;
    Score _score;
    ScoreView _scoreView;
    private void Awake()
    {
        _score = new Score();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6 && Input.GetKey(_key))
        {
            Destroy(collision.gameObject);
        }
    }
}
