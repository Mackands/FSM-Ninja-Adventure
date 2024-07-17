using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.NinjaStates.SuperStates
{
    public class NinjaAbilityState : NinjaState
    {
        protected bool isAbilityDone;

        private bool isGrounded;

        public NinjaAbilityState(Ninja ninja, NinjaStateMachine stateMachine, NinjaData ninjaData, string animBoolName) : base(ninja, stateMachine, ninjaData, animBoolName)
        {
        }

        public override void DoCheck()
        {
            base.DoCheck();

            isGrounded = ninja.CheckIfGrounded();
        }

        public override void Enter()
        {
            base.Enter();

            isAbilityDone = false;
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            if (isAbilityDone)
            {
                if (isGrounded && ninja.CurrentVelocity.x < 0.01f)
                {
                    stateMachine.ChangeState(ninja.IdleState);
                }
                else
                {
                    stateMachine.ChangeState(ninja.InAirState);
                }
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}