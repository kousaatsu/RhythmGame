using System;

public interface IScoreManager
{
    void AddScore(int value);
    void IncreaseMissCount();
    int GetScore();
    int GetMissCount();
    event Action<int> OnScoreChanged;
    event Action<int> OnMissCountChanged;
}
