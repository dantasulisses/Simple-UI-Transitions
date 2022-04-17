using UnityEngine;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Uli.Transition
{
    /// <summary>
    /// Base class for any type of UI object that makes animated/tween inputs
    /// </summary>
    public class BaseTransition : MonoBehaviour
    {
        /// <summary>
        /// Inicia como true, pois geralmente a cena esta configurada para já estar exibida no editor
        /// </summary>
        public bool hasEntered = true;
        public bool doOnStart = false;

        #region ODIN INSPECTOR
#if ODIN_INSPECTOR
        [Button]
        private void SetTransitionOn() 
        {
            SetState(true);
        }
        [Button]
        private void SetTransitionOff()
        {
            SetState(false);
        }
#endif
        #endregion
        public virtual void OnEnable()
        {
            if (doOnStart)
                DoTween(true);
        }
        public virtual void SetState(bool doEnable)
        {
            hasEntered = doEnable;
        }
        public virtual void DoTween(bool doEnable)
        {
            hasEntered = doEnable;
        }
    }
}