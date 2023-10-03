using DG.Tweening;
using UnityEngine;

namespace Uli.Transition
{
    public class CanvasGroupTransition : TweenTransition
    {
        private CanvasGroup targetCanvas;
        private CanvasGroup TargetCanvas
        {
            get
            {
                if (targetCanvas == null) targetCanvas = objectToTween.GetComponent<CanvasGroup>();
                return targetCanvas;
            }
            set => targetCanvas = value;
        }
        [Header("ALPHA 0 = Out, ALPHA 1 = IN")]
        public float[] alphaRefs = new float[2] { 0, 1 };

        public bool disableGOWhenDone = false;

        public override void SetState(bool doEnable)
        {
            if (hasEntered == doEnable)
                return;

            base.SetState(doEnable);

            if (doEnable)
            {
                EnableObject(true);
                EnableInteractions(true);
                EnableBlockRaycasts(true);
                TargetCanvas.alpha = alphaRefs[1];
            }
            else
            {
                EnableObject(false);
                EnableInteractions(false);
                EnableBlockRaycasts(false);
                TargetCanvas.alpha = alphaRefs[0];
            }
        }
        public override void DoTween(bool doEnable)
        {
            if (hasEntered == doEnable)
                return;

            base.DoTween(doEnable);

            if (doEnable)
            {
                EnableObject(true);
                EnableBlockRaycasts(true);
                TargetCanvas.DOFade(alphaRefs[1], movementTime).SetDelay(enterDelay).SetEase(tweenType).SetDelay(enterDelay).SetUpdate(true).OnComplete(() => EnableInteractions(true));
            }
            else
            {
                EnableInteractions(false);
                EnableBlockRaycasts(false);
                TargetCanvas.DOFade(alphaRefs[0], movementTime).SetDelay(enterDelay).SetEase(tweenType).SetDelay(exitDelay).SetUpdate(true).OnComplete(() => 
                {
                    //Extra check in case of simultaneously cancelling(killing) the current fade-out and doing a fade-in
                    if (hasEntered == false)
                        EnableObject(false);
                });
            }
        }
        public override void ToggleState()
        {
            DoTween(!hasEntered);
        }
        private void EnableObject(bool doEnable)
        {
            if (disableGOWhenDone)
                objectToTween.gameObject.SetActive(doEnable);
        }
        private void EnableInteractions(bool doEnable)
        {
            TargetCanvas.interactable = doEnable;
        }
        private void EnableBlockRaycasts(bool doEnable)
        {
            TargetCanvas.blocksRaycasts = doEnable;
        }
    }
}