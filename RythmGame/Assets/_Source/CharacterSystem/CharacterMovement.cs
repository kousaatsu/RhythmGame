using Interfaces;
using UnityEngine;

namespace CharacterSystem
{
    public class CharacterMovement : IContollable
    {
        public void Moving(Rigidbody2D rb, float speed, Vector2 direction)
        {
            Vector2 vel = direction * speed;
            rb.velocity = new Vector2 (vel.x, vel.y);
        }
        public void Move(Rigidbody2D rb, float speed, Vector2 direction)
        {
            Moving (rb, speed, direction);
        }
    }
}

