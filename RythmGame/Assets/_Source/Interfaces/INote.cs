using System;

public interface INote
{
    void Move(float speed);
    void OnTap();
    float GetSpeed();
}
