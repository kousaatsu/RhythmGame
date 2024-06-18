using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;
using TMPro;

public class NoteTap : MonoBehaviour
{
    [field: SerializeField] KeyCode _key;
    [field: SerializeField] int _scoreVal;
    [field: SerializeField] TextMeshProUGUI _scoreText;
    [Header("Clips")]
    [field: SerializeField] GameObject _audioSource;
    [field: SerializeField] AudioClip _noTap;
    [field: SerializeField] AudioClip _tap;
    [field: SerializeField] AudioClip _lose;
    bool _beingTriggered;
    bool _isTapped = false;
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
            _scoreText.text = "Good!";
            _isTapped = true;
            _audioSource.GetComponent<AudioSource>().PlayOneShot(_tap);
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            if (_isTapped == false)
            {
                _audioSource.GetComponent<AudioSource>().PlayOneShot(_lose);
                _scoreText.text = "Miss!";
            }
            _beingTriggered = false;

            Destroy(collision.gameObject);
        }
    }
}
