using TMPro;
using UnityEngine;

namespace ScoreSystem
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI scoreText;
        Score _score;

        private void Awake()
        {
            _score = new Score();
        }
        private void Start()
        {
            scoreText.text = $"Score: {_score.ScoreValue}";
        }

        public void RefreshScoreText()
        {
            scoreText.text = $"Score: {_score.ScoreValue}";
        }
    }
}
