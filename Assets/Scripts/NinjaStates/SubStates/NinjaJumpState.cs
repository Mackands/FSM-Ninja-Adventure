using Assets.Scripts.NinjaStates.SuperStates;
using UnityEngine;

namespace Assets.Scripts.NinjaStates.SubStates
{
    public class NinjaJumpState : NinjaAbilityState
    {
        public NinjaJumpState(Ninja ninja, NinjaStateMachine stateMachine, NinjaData ninjaData, string animBoolName) : base(ninja, stateMachine, ninjaData, animBoolName)
        {
        }

        public override void Enter()
        {
            base.Enter();

            ninja.SetVelocityY(ninjaData.jumpVelocity);
            isAbilityDone = true;
        }
    }
}