using System;

public class ScoreManager : IScoreManager
{
    private int _score;
    private int _missCount;
    public event Action<int> OnScoreChanged;
    public event Action<int> OnMissCountChanged;

    public void AddScore(int value)
    {
        _score += value;
        OnScoreChanged?.Invoke(_score);
    }

    public int GetScore() => _score;

    public void IncreaseMissCount()
    {
        _missCount++;
        OnMissCountChanged?.Invoke(_missCount);
    }

    public int GetMissCount() => _missCount;
}
