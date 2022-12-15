using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace _Project.Scripts.Main.Services
{
    public class ScreenService : BaseService
    {
        [SerializeField] private Camera _mainCamera;
        [SerializeField] private Camera _uiCamera;
        [SerializeField] private PostProcessVolume _postProcessVolume;
        [SerializeField] private PostProcessLayer _postProcessLayer;

        public Camera MainCamera => _mainCamera;
        public Camera UICamera => _uiCamera;
        public PostProcessVolume PostProcessVolume => _postProcessVolume;
        public PostProcessLayer PostProcessLayer => _postProcessLayer;
    }
}