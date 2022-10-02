using UnityEngine;

namespace _Project.Infrastructure
{
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody2D body;

        private float horizontal;
        private float vertical;

        public float runSpeed = 0.3f;

        void Start()
        {
            body = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
        }

        private void FixedUpdate()
        {
            body.velocity = new Vector2(horizontal, vertical).normalized * this.runSpeed;
        }
    }
}