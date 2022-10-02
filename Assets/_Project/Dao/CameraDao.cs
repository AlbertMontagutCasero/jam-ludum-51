using Cinemachine;
using UnityEngine;

namespace LudumDare51.Dao
{
    public class CameraDao: Dao
    {
        private readonly Camera camera;

        public CameraDao(Camera camera)
        {
            this.camera = camera;
        }

        public Camera GetCamera()
        {
            return this.camera;
        }
        
        public CinemachineVirtualCameraBase GetCinemachineCamera()
        {
            return this.camera.GetComponent<CinemachineVirtualCamera>();
        }
    }
}