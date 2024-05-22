using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

public class NoteTap : MonoBehaviour
{
    [field: SerializeField] KeyCode _key;
    [field: SerializeField] int _scoreVal;
    [Header("Clips")]
    [field: SerializeField] GameObject _audioSource;
    [field: SerializeField] AudioClip _noTap;
    [field: SerializeField] AudioClip _tap;
    [field: SerializeField] AudioClip _lose;
    bool _beingTriggered;
    Score _score;
    ScoreView _scoreView;
    private void Awake()
    {
        _score = new Score();
    }

    private void Update()
    {
        if (Input.GetKeyDown(_key) && _beingTriggered == false)
        {
            _audioSource.GetComponent<AudioSource>().PlayOneShot(_noTap);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        _beingTriggered = true;
        if (collision.gameObject.layer == 6 && Input.GetKey(_key))
        {
            _audioSource.GetComponent<AudioSource>().PlayOneShot(_tap);
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            _beingTriggered = false;
            _audioSource.GetComponent<AudioSource>().PlayOneShot(_lose);
            Destroy(collision.gameObject);
        }
    }
}
