using System;
using UnityEngine;
using TMPro;

namespace NoteSystemNew
{

    public class NoteTap : MonoBehaviour
    {
        [SerializeField] GameObject _losingPanel;
        [SerializeField] KeyCode _key;
        [SerializeField] int _scoreVal;
        [SerializeField] TextMeshProUGUI _scoreText;
        [SerializeField] AudioClip _noTap;
        [SerializeField] AudioClip _tap;
        [SerializeField] AudioClip _lose;

        IScoreManager _scoreManager;
        static int _maxMisses = 5;
        bool _isTriggered = false;

        private void Awake()
        {
            _scoreManager = new ScoreManager();
            _scoreManager.OnMissCountChanged += HandleMissCountChanged;
        }

        private void Update()
        {
            if (Input.GetKeyDown(_key))
            {
                // Обработка нажатия
            }
        }

        private void HandleMissCountChanged(int missCount)
        {
            if (missCount >= _maxMisses)
            {
                Time.timeScale = 0f;
                _losingPanel.SetActive(true);
            }
        }

        public void HandleNoteTap(INote note)
        {
            note.OnTap();
            _scoreManager.AddScore(_scoreVal);
            _scoreText.text = "Good!";
            // Play _tap sound
        }

        public void HandleNoteMiss()
        {
            _scoreManager.IncreaseMissCount();
            _scoreText.text = "Miss!";
            // Play _lose sound
        }
    }
}
