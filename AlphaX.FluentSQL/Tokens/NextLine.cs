namespace AlphaX.FluentSQL.Tokens
{
    public class NextLine : QueryToken
    {
        public NextLine(IQueryContext context) : base(context)
        {
        }

        public override string GetValue()
        {
            return null;
        }
    }
}
