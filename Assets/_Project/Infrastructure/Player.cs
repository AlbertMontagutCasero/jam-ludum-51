using LudumDare51.Dao;
using LudumDare51.Interactor;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

namespace LudumDare51.Infrastructure
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D body;
        private Animator animator;

        private string lastAnimation = "idle";
        
        public float runSpeed = 0.3f;
        public Vector2 startPosition = Vector2.zero;
        private Vector2 inputDirection;

        private void Awake()
        {
            GameSignals.OnGameplayStarts += OnGameplayStarts;
            
            this.body = GetComponent<Rigidbody2D>();
            this.animator = this.GetComponent<Animator>();
            this.inputDirection = Vector2.zero;
        }

        private void OnGameplayStarts(GameDataDao gameDataDao)
        {
            this.body.MovePosition(startPosition);
        }

        private void Update()
        {
            this.inputDirection.x = Input.GetAxisRaw("Horizontal");
            this.inputDirection.y = Input.GetAxisRaw("Vertical");
        }

        private void FixedUpdate()
        {
            body.velocity = this.inputDirection.normalized * this.runSpeed;
        }

        private void LateUpdate()
        {
            var movementDirection = this.inputDirection;
            var isMovingForward = movementDirection.y > 0;
            var isMovingBack = movementDirection.y < 0;
            var isMovingVertical = isMovingForward || isMovingBack;

            if (isMovingVertical)
            {
                if (isMovingForward)
                {
                    this.animator.Play("back");
                }

                if (isMovingBack)
                {
                    this.animator.Play("forward");
                }

                return;
            }

            var isMovingRight = movementDirection.x > 0;
            var isMovingLeft = movementDirection.x < 0;
            var isMovingHorizontal = isMovingLeft || isMovingRight;
            
            if (isMovingHorizontal)
            {
                if (isMovingRight)
                {
                    this.animator.Play("right");
                }

                if (isMovingLeft)
                {
                    this.animator.Play("left");
                }
                return;
            }
            
            this.animator.Play("idle");
        }
    }
}