using UnityEngine;

namespace Interfaces
{
    public interface IContollable
    {
        public void Move(Rigidbody2D rb, float speed, Vector2 direction);
    }

}
