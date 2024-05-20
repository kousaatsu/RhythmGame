using System;
using UnityEngine;

namespace ScoreSystem
{
    public class Score
    {
        public int ScoreValue { get; private set; }

        public void AddScore(int adding)
        {
            ScoreValue += adding;
        }
    }

}
