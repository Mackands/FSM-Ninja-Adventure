using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.NinjaStates.SuperStates
{
    public class NinjaGroundedStates : NinjaState
    {
        protected int xInput;

        public bool JumpInput;
        public bool AttackInput;

        public NinjaGroundedStates(Ninja ninja, NinjaStateMachine stateMachine, NinjaData ninjaData, string animBoolName) : base(ninja, stateMachine, ninjaData, animBoolName)
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

            xInput = ninja.InputHandler.NormInputX;
            JumpInput = ninja.InputHandler.JumpInput;

            if (JumpInput)
            {
                ninja.InputHandler.UseJumpInput();
                stateMachine.ChangeState(ninja.JumpState);
            }

            else if (AttackInput)
            {
                ninja.InputHandler.UseAttackInput();
                stateMachine.ChangeState(ninja.AttackState);
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}