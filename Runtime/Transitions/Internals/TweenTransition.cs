using DG.Tweening;
using UnityEngine;

namespace Uli.Transition
{
    /// <summary>
    /// Basis for tween transitions
    /// </summary>
    public class TweenTransition : BaseTransition
    {
        public Transform objectToTween;
        public Ease tweenType = Ease.OutQuad;
        public float movementTime = 0.3f;
        public float enterDelay = 0;
        public float exitDelay = 0;

        public override void SetState(bool doEnable)
        {
            if (DOTween.IsTweening(objectToTween))
                DOTween.Kill(objectToTween, true);

            base.SetState(doEnable);
        }
        public override void DoTween(bool doEnable)
        {
            if (DOTween.IsTweening(objectToTween))
                DOTween.Kill(objectToTween, true);

            base.DoTween(doEnable);
        }
        public override void ToggleState()
        {
            DoTween(!hasEntered);
        }
    }
}