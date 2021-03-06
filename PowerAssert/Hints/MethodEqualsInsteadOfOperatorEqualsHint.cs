﻿namespace PowerAssert.Hints
{
    class MethodEqualsInsteadOfOperatorEqualsHint : OperatorEqualsHintBase
    {
        protected override bool TryGetHint(object left, object right, out string hint)
        {
            if (Equals(left, right))
            {
                hint = ", but would have been True with Equals()";
                return true;
            }

            hint = null;
            return false;
        }
    }
}