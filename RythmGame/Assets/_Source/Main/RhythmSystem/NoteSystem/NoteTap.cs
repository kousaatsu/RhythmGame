using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;
using TMPro;

public class NoteTap : MonoBehaviour
{
    [field: SerializeField] GameObject _losingPanel;
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
    static int _countMisses;
    private void Awake()
    {
        _countMisses = 0;
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
                _countMisses++;
                Debug.Log(_countMisses);
                _audioSource.GetComponent<AudioSource>().PlayOneShot(_lose);
                _scoreText.text = "Miss!";
                if (_countMisses == 5)
                {
                    Time.timeScale = 0f;
                    _losingPanel.SetActive(true);
                }
            }
            _isTapped = false;
            _beingTriggered = false;

            Destroy(collision.gameObject);
        }
    }
}
