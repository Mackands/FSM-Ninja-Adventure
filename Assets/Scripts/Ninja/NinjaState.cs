using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class NinjaState
    {
        protected Ninja ninja;
        protected NinjaStateMachine stateMachine;
        protected NinjaData ninjaData;

        protected float startTime;

        private string animBoolName;

        public NinjaState(Ninja ninja, NinjaStateMachine stateMachine, NinjaData ninjaData, string animBoolName)
        {
            this.ninja = ninja;
            this.stateMachine = stateMachine;
            this.ninjaData = ninjaData;
            this.animBoolName = animBoolName;
        }

        public virtual void Enter()
        {
            DoCheck();
            ninja.Anim.SetBool(animBoolName, true);
            startTime = Time.time;
            Debug.Log(animBoolName);
        }

        public virtual void Exit()
        {
            ninja.Anim.SetBool(animBoolName, false);
        }

        public virtual void LogicUpdate()
        {

        }

        public virtual void PhysicsUpdate()
        {
            DoCheck();
        }

        public virtual void DoCheck()
        {

        }
    }
}