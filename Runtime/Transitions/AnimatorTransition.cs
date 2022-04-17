using UnityEngine;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Uli.Transition
{
    /// <summary>
    /// Does a transition setting a animator boolean value
    /// </summary>
    public class AnimatorTransition : BaseTransition
    {
        public Animator myAnimator = null;
#if ODIN_INSPECTOR
        [InfoBox("The desired animator boolean to set on or off when doing this transition")]
#endif
        public string animatorEnablePropertyName = "enable";
        
        public override void SetState(bool doEnable)
        {
            DoTween(doEnable);
        }
        public override void DoTween(bool doEnable)
        {
            if (hasEntered == doEnable)
                return;

            base.DoTween(doEnable);

            if (myAnimator != null)
            {
                myAnimator.SetBool(animatorEnablePropertyName, doEnable);
            }
        }
        public override void ToggleState()
        {
            DoTween(!hasEntered);
        }
    }
}