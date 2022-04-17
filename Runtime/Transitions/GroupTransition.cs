namespace Uli.Transition
{
    /// <summary>
    /// Helper class to do multiple basetransition at once
    /// </summary>
    public class GroupTransition : BaseTransition
    {
        public BaseTransition[] groups;

        public override void SetState(bool doEnable)
        {
            base.SetState(doEnable);

            for (int x = 0; x < groups.Length; x++)
            {
                groups[x].SetState(doEnable);
            }
        }
        public override void DoTween(bool doEnable)
        {
            base.DoTween(doEnable);

            for (int x = 0; x < groups.Length; x++)
            {
                groups[x].DoTween(doEnable);
            }
        }
    }
}