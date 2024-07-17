using UnityEngine;

namespace Assets.Scripts.Utility
{
    public class CameraFollow : MonoBehaviour
    {
        #region Camera Variables
        public Transform target; // The target to follow (the player)
        public Vector3 offset;   // Offset from the target
        public float smoothSpeed = 0.125f; // Smoothness of the camera movement
        #endregion

        #region Camera Follow Function
        private void LateUpdate()
        {
            if (target == null)
                return;

            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
        #endregion
    }
}