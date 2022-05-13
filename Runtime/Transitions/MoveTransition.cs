using DG.Tweening;
using UnityEngine;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Uli.Transition
{
    public class MoveTransition : TweenTransition
    {
        [Header("POS 0 = Out, POS 1 = IN")]
        public Transform[] moveRefs = new Transform[2];

        #region INSPECTOR
#if ODIN_INSPECTOR
        [Button]
        private void CreateOrResetMoveReferences() 
        {
            RectTransform rectTransform = objectToTween.GetComponent<RectTransform>();
            for (int x = 0; x < moveRefs.Length; x++)
            {
                if (moveRefs[x] == null)
                {
                    GameObject g = new GameObject(string.Format("MoveRef_{0}_{1}", x, gameObject.name));
                    if (rectTransform != null)
                        g.AddComponent(typeof(RectTransform));

                    moveRefs[x] = g.GetComponent<Transform>();
                    moveRefs[x].SetParent(objectToTween.parent);
                }

                moveRefs[x].CopyValuesFrom(objectToTween);
                if (rectTransform != null)
                    ((RectTransform)moveRefs[x]).CopyValuesFrom(rectTransform);
            }
        }
#endif
        #endregion
        public override void SetState(bool doEnable)
        {
            if (hasEntered == doEnable)
                return;

            base.SetState(doEnable);

            if (doEnable)
                objectToTween.transform.position = moveRefs[1].position;
            else
                objectToTween.transform.position = moveRefs[0].position;
        }
        public override void DoTween(bool doEnable)
        {
            if (hasEntered == doEnable)
                return;

            base.DoTween(doEnable);

            if (doEnable)
                objectToTween.DOMove(moveRefs[1].position, movementTime).SetEase(tweenType).SetDelay(enterDelay).SetUpdate(true);
            else
                objectToTween.DOMove(moveRefs[0].position, movementTime).SetEase(tweenType).SetDelay(exitDelay).SetUpdate(true);
        }
        public override void ToggleState()
        {
            DoTween(!hasEntered);
        }
    }
}