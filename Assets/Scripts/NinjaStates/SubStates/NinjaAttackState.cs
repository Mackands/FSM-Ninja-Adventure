using Assets.Scripts.NinjaStates.SuperStates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.NinjaStates.SubStates
{
    public class NinjaAttackState : NinjaAbilityState
    {
        public NinjaAttackState(Ninja ninja, NinjaStateMachine stateMachine, NinjaData ninjaData, string animBoolName) : base(ninja, stateMachine, ninjaData, animBoolName)
        {
        }

        public override void Enter()
        {
            base.Enter();
            isAbilityDone = true;
        }
    }
}