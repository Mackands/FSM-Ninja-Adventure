using Assets.Scripts.NinjaStates.SuperStates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.NinjaStates.SubStates
{
    public class NinjaIdleState : NinjaGroundedStates
    {
        public NinjaIdleState(Ninja ninja, NinjaStateMachine stateMachine, NinjaData ninjaData, string animBoolName) : base(ninja, stateMachine, ninjaData, animBoolName)
        {
        }

        public override void DoCheck()
        {
            base.DoCheck();
        }

        public override void Enter()
        {
            base.Enter();
            ninja.SetVelocityX(0);
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            if (xInput != 0f)
            {
                stateMachine.ChangeState(ninja.RunState);
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}