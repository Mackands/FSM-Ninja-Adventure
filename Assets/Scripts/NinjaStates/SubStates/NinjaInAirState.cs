using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.NinjaStates.SubStates
{
    public class NinjaInAirState : NinjaState
    {
        public NinjaInAirState(Ninja ninja, NinjaStateMachine stateMachine, NinjaData ninjaData, string animBoolName) : base(ninja, stateMachine, ninjaData, animBoolName)
        {
        }
    }
}