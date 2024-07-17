using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName ="newNinjaData", menuName ="Data/Ninja Data/Base Data")]
    public class NinjaData : ScriptableObject
    {
        [Header("Run State")]
        public float movementVelocity = 10f;

        [Header("Jump State")]
        public float jumpVelocity = 15f;

        [Header("Check Variables State")]
        public float groundCheckRadius = 0.3f;
        public LayerMask whatIsGround;

        [Header("Check Variables State")]
        public float attackRange = 1f; // Range of the attack
        public LayerMask enemyLayers; // Layers considered as enemies
    }
}