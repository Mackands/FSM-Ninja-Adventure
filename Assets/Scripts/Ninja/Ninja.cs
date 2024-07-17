using Assets.Scripts.NinjaStates.SubStates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Ninja : MonoBehaviour
    {
        #region State Variables
        public NinjaStateMachine StateMachine { get; private set; }

        public NinjaIdleState IdleState { get; private set; }
        public NinjaRunState RunState { get; private set; }
        public NinjaAttackState AttackState { get; private set; }
        public NinjaJumpState JumpState { get; private set; }
        public NinjaInAirState InAirState { get; private set; }
        public NinjaRunState SlideState { get; private set; }
        public NinjaRunState DieState { get; private set; }
        #endregion

        #region Components

        public Animator Anim { get; private set; }
        public PlayerInputHandler InputHandler { get; private set; }
        public Rigidbody2D RB { get; private set; }
        #endregion

        #region Check Transform
        [SerializeField]
        private Transform groundCheck;
        #endregion

        #region Other Variables
        public Vector2 CurrentVelocity { get; private set; }
        public int FacingDirection { get; private set; }

        [SerializeField]
        private NinjaData ninjaData;

        private Vector2 workspace;
        #endregion

        #region Unity Callback Functions
        private void Awake()
        {
            StateMachine = new NinjaStateMachine();

            IdleState = new NinjaIdleState(this, StateMachine, ninjaData, "Idle");
            RunState = new NinjaRunState(this, StateMachine, ninjaData, "Run");
            AttackState = new NinjaAttackState(this, StateMachine, ninjaData, "Attack");
            JumpState = new NinjaJumpState(this, StateMachine, ninjaData, "Jump");
            InAirState = new NinjaInAirState(this, StateMachine, ninjaData, "Jump");
        }

        private void Start()
        {
            Anim = GetComponent<Animator>();
            InputHandler = GetComponent<PlayerInputHandler>();
            RB = GetComponent<Rigidbody2D>();

            FacingDirection = 1;

            StateMachine.Initiaalize(IdleState);
        }

        private void Update()
        {
            CurrentVelocity = RB.velocity;

            StateMachine.CurrentState.LogicUpdate();
        }

        private void FixedUpdate()
        {
            StateMachine.CurrentState.PhysicsUpdate();
        }
        #endregion

        #region Set Functons
        public void SetVelocityX(float velocity)
        {
            workspace.Set(velocity, CurrentVelocity.y);
            RB.velocity = workspace;
            CurrentVelocity = workspace;
        }

        public void SetVelocityY(float velocity)
        {
            workspace.Set(CurrentVelocity.x, velocity);
            RB.velocity = workspace;
            CurrentVelocity = workspace;
        }
        #endregion

        #region Check Function
        public void CheckIfShouldFlip(int xInput)
        {
            if (xInput != 0 && xInput != FacingDirection)
            {
                Flip();
            }
        }

        public bool CheckIfGrounded()
        {
            // Check if the player is on the ground
            return  Physics2D.OverlapCircle(groundCheck.position, ninjaData.groundCheckRadius, ninjaData.whatIsGround);
        }
        #endregion

        #region Other Function
        private void Flip()
        {
            FacingDirection *= -1;
            transform.Rotate(0.0f, 180.0f, 0.0f);
        }

        void OnDrawGizmosSelected()
        {
            // Visualize the attack range in the editor
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, ninjaData.attackRange);
        }
        #endregion
    }
}