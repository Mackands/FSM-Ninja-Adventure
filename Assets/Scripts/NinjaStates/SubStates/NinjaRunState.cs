using Assets.Scripts.NinjaStates.SuperStates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.NinjaStates.SubStates
{
    public class NinjaRunState : NinjaGroundedStates
    {
        public NinjaRunState(Ninja ninja, NinjaStateMachine stateMachine, NinjaData ninjaData, string animBoolName) : base(ninja, stateMachine, ninjaData, animBoolName)
        {
        }

        public override void DoCheck()
        {
            base.DoCheck();
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            ninja.CheckIfShouldFlip(xInput);

            ninja.SetVelocityX(ninjaData.movementVelocity * xInput);

            if (xInput == 0f)
            {
                stateMachine.ChangeState(ninja.IdleState);
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}