using Assets.Scripts.NinjaStates.SuperStates;

namespace Assets.Scripts.NinjaStates.SubStates
{
    public class NinjaLandState : NinjaGroundedStates
    {
        public NinjaLandState(Ninja ninja, NinjaStateMachine stateMachine, NinjaData ninjaData, string animBoolName) : base(ninja, stateMachine, ninjaData, animBoolName)
        {
        }
    }
}