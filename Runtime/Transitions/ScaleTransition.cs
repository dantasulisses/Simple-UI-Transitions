using DG.Tweening;
using UnityEngine;

namespace Uli.Transition
{
    public class ScaleTransition : TweenTransition
    {
        [Header("0 = Out, 1 = IN")]
        public Vector3[] scaleRefs = new Vector3[2] { Vector3.zero, Vector3.one };

        public override void SetState(bool doEnable)
        {
            if (hasEntered == doEnable)
                return;

            base.SetState(doEnable);

            if (doEnable)
                objectToTween.transform.localScale = scaleRefs[1];
            else
                objectToTween.transform.localScale = scaleRefs[0];
        }
        public override void DoTween(bool doEnable)
        {
            if (hasEntered == doEnable)
                return;
            
            base.DoTween(doEnable);

            if (doEnable)
                objectToTween.DOScale(scaleRefs[1], movementTime).SetEase(tweenType).SetDelay(enterDelay).SetUpdate(true);
            else
                objectToTween.DOScale(scaleRefs[0], movementTime).SetEase(tweenType).SetDelay(exitDelay).SetUpdate(true);
        }
        public override void ToggleState()
        {
            DoTween(!hasEntered);
        }
    }
}